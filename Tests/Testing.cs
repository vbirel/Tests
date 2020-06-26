using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Tests
{
    public partial class Testing : Form
    {
        private static string nameTable = "", answers, trueAnswer;
        private static List<ClassQuestion> listQuestion = new List<ClassQuestion>();

        private static string[] answerMas;

        private static int curientNamber, trueCaunt, typeQuestion, cauntAnswrs, balls=0;

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string thisAnswer = "";
            bool rigt = false;

            if(listQuestion[curientNamber-1].typeQuestion==1)
            {
                for(int i=0; i< splitContainer2.Panel1.Controls.Count;i+=2)
                {
                    RadioButton rb = splitContainer2.Panel1.Controls[i] as RadioButton;

                    if(rb.Checked)
                    {
                        thisAnswer += "+";
                    }else
                    {
                        thisAnswer += "-";
                    }
                }

                if(thisAnswer==trueAnswer)
                {
                    balls++;
                }
            }
            else if(listQuestion[curientNamber - 1].typeQuestion == 2)
            {
                for (int i = 0; i < splitContainer2.Panel1.Controls.Count; i += 2)
                {
                    CheckBox cb = splitContainer2.Panel1.Controls[i] as CheckBox;

                    if (cb.Checked)
                    {
                        thisAnswer += "+";
                    }
                    else
                    {
                        thisAnswer += "-";
                    }
                }
            }
            else if (listQuestion[curientNamber - 1].typeQuestion == 3)
            {
               
              TextBox tb = splitContainer2.Panel1.Controls[0] as TextBox;
                if(tb.Text==trueAnswer)
                {
                    balls++;
                }                   
                
            }
            else if (listQuestion[curientNamber - 1].typeQuestion == 4)
            {

                for(int i=0; i<splitContainer2.Panel1.Controls.Count;i++)
                {
                    string s = "";

                    ComboBox cb1 = splitContainer2.Panel1.Controls[i] as ComboBox;
                    ComboBox cb2 = splitContainer2.Panel1.Controls[i+1] as ComboBox;

                    s += cb1.SelectedItem.ToString() + "&" + cb2.SelectedItem.ToString();

                    if(s==answerMas[i])
                    {
                        balls += 1 / answerMas.Length;
                    }
                }
            }

            curientNamber++;

            if(curientNamber<listQuestion.Count)
            {
                curientNamber++;
                openQeshon();
            }
            else
            {
                int mark=0;

                if(balls==listQuestion.Count)
                {
                    MessageBox.Show("ваша оценка 5");
                    mark = 5;
                }
                else if(balls >= listQuestion.Count/1.5)
                {
                    MessageBox.Show("ваша оценка 4");
                    mark = 4;
                }
                else if (balls >= listQuestion.Count / 2)
                {
                    MessageBox.Show("ваша оценка 3");
                    mark = 3;
                }
                else 
                {
                    MessageBox.Show("ваша оценка 2");
                    mark = 2;
                }

                this.resultTableAdapter1.Insert(Information.idStudent, Information.idTest, DateTime.Now, mark);
                this.Close();
            }
        }

        public Testing()
        {
            InitializeComponent();
        }

        private void Testing_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Information.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            string commandS = "";

            string textQshon;
           

            listQuestion.Clear();
            nameTable = Information.nameTest + "_" + Convert.ToString(Information.idTicer);

            try
            {
                commandS = "SELECT * FROM " + nameTable;
                command.CommandText = commandS;
                SqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    textQshon = dataReader["Text_question"].ToString();
                    typeQuestion = (int)dataReader["Type_question"];
                    answers = dataReader["Answers"].ToString();

                    ClassQuestion question = new ClassQuestion(textQshon, typeQuestion, answers);
                    listQuestion.Add(question);
                }
                dataReader.Close();
                connection.Close();

               int cauntQeshon = listQuestion.Count();

                progressBar1.Maximum = cauntQeshon;

                curientNamber = 1;
                trueCaunt = 0;

                openQeshon();
        }
            catch
            {
                MessageBox.Show(" Данный тест был удален, или произашла непредвиденая ошибка"
                    );
                connection.Close();
                return;
            }
        }


        public  void openQeshon()
        {
            ClassQuestion question = listQuestion[curientNamber - 1];

            this.textBox1.Text = question.textQuestion;
            typeQuestion = question.typeQuestion;
            answers = question.answers;
            answerMas = answers.Split(';');
            Array.Resize(ref answerMas, answerMas.Length - 1);         
            cauntAnswrs = answerMas.Length;
            splitContainer2.Panel1.Controls.Clear();
            trueAnswer = "";

            if(listQuestion[curientNamber-1].typeQuestion==1)
            {
                for(int i = 0; i<cauntAnswrs;i++)
                {
                    trueAnswer += answerMas[i][0];

                    Information.RadioButtonDynamic(splitContainer2.Panel1, 20, 40 + i * 30 + i * 10, 30, 30);
                    Information.LabelDynamic(splitContainer2.Panel1, 60, 40 + i * 30 + i * 10, splitContainer2.Panel1.Width - 70, 30, answerMas[i].Remove(0,1));
                }
            }
            else if (listQuestion[curientNamber - 1].typeQuestion == 2)
            {
                for (int i = 0; i < cauntAnswrs; i++)
                {
                    trueAnswer += answerMas[i][0];

                    Information.CheckBoxDynamic(splitContainer2.Panel1, 20, 40 + i * 30 + i * 10, 30, 30);
                    Information.LabelDynamic(splitContainer2.Panel1, 60, 40 + i * 30 + i * 10, splitContainer2.Panel1.Width - 70, 30, answerMas[i].Remove(0, 1));
                }
            }
            else if (listQuestion[curientNamber - 1].typeQuestion == 3)
            {
               
                    trueAnswer = answers;

                Information.TextBoxDynamic(splitContainer2.Panel1, 30, 40 + 30 + 10, splitContainer2.Panel1.Width - 70, 30);


            }
            else if (listQuestion[curientNamber - 1].typeQuestion == 4)
            {
              string[] answerForСonformity = new String[answerMas.Length*2];
                string[] answer1 = new string[answerMas.Length];
                string[] answer2 = new string[answerMas.Length];
                for (int i=0; i < answerMas.Length;i++)
                {
                    answerForСonformity = answerMas[i].Split('&');

                    answer1[i] = answerForСonformity[0];
                    answer2[i] = answerForСonformity[1];
                }

                answerForСonformity = answer1.Union(answer2).ToArray();
                
                for (int i = 0; i < cauntAnswrs; i++)
                {                    

                    int a = splitContainer2.Panel1.Width / 2;
                    Information.ComboBoxDynamic(splitContainer2.Panel1, 10, 40 + i * 30 + i * 10, a, 30, answerForСonformity);
                    Information.ComboBoxDynamic(splitContainer2.Panel1, a + 30, 40 + i * 30 + i * 10, a - 45, 30, answerForСonformity);
                }
            }

        }
    }
}
