using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InputBox;
using System.Data.SqlClient;


namespace Tests
{
    public partial class CreateTest : Form
    {

        private static int curentQechon = 0, cauntQechon=0;
        private static bool save = false;

       private static List<ClassQuestion> listQuestions = new List<ClassQuestion>();
        public CreateTest()
        {
            InitializeComponent();
        }

        private void CreateTest_Load(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            buttonAdd.Visible = false;
            buttonSave.Visible = false;
            buttonReturn.Visible = false;
            toolStripStatusDate.Text += DateTime.Now.ToLongDateString();
            toolStripStatusNumber.Text += Convert.ToString(curentQechon);
            
        }

        private void новыйТэстToolStripMenuItem_Click(object sender, EventArgs e)//создать новый тэст
        {
            InputBox.InputBox inputBox = new InputBox.InputBox("Название", "Введите название тэста");

            Information.nameTest = inputBox.getString();
            toolStripStatusName.Text += Information.nameTest;
            toolStrip1.Visible = true;
            buttonAdd.Visible = true;
            buttonSave.Visible = true;
            buttonReturn.Visible = true;
        }

        private static int needIt = 0;
        private void buttonAdd_Click(object sender, EventArgs e)//добавить вариант ответа
        {
            save = true;
            if (Information.taupOfTest == 1)
            {
                toolStripStatusTape.Text += ": один ответ";
                toolStripStatusNumberOfQuestions.Text = "вопросов всего:" + Convert.ToString(cauntQechon);
                
                    Information.RadioButtonDynamic(splitContainer3.Panel2, 20, 40 + needIt * 30 + needIt * 10, 30, 30);
                    Information.TextBoxDynamic(splitContainer3.Panel2, 60, 40 + needIt * 30 + needIt * 10, splitContainer3.Panel2.Width - 70, 30);
                needIt++;

            }
            else if (Information.taupOfTest == 2)
            {
                toolStripStatusTape.Text += ": несколько ответов";
                toolStripStatusNumberOfQuestions.Text = "вопросов всего:" + Convert.ToString(cauntQechon);
               
                    Information.CheckBoxDynamic(splitContainer3.Panel2, 20, 40 + needIt * 30 + needIt * 10, 30, 30);
                    Information.TextBoxDynamic(splitContainer3.Panel2, 60, 40 + needIt * 30 + needIt * 10, splitContainer3.Panel2.Width - 70, 30);
                needIt++;
            }
            else if (Information.taupOfTest == 4)
            {
                int a = splitContainer3.Panel2.Width / 2;
                toolStripStatusTape.Text += ": соответствие";
                toolStripStatusNumberOfQuestions.Text = "вопросов всего:" + Convert.ToString(cauntQechon);
                
                    Information.TextBoxDynamic(splitContainer3.Panel2, 10, 40 + needIt * 30 + needIt * 10, a, 30);
                    Information.TextBoxDynamic(splitContainer3.Panel2, a + 30, 40 + needIt * 30 + needIt * 10, a - 45, 30);
                needIt++;
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)//очистить вопрос
        {
            textBox1.Text = "";
            splitContainer3.Panel2.Controls.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)//сохранить вопрос
        {
            bool loog;
            string ans = "";
            if (textBox1.Text != "")
            {
                 loog = true;
            }
            else
            {
                 loog = false;
            }
            int caunter = 0;
            if(Information.taupOfTest == 1)
            {
                for(int i = 0; i<splitContainer3.Panel2.Controls.Count; i+=2)
                {
                    RadioButton rb = splitContainer3.Panel2.Controls[i] as RadioButton;                    
                    TextBox tb = splitContainer3.Panel2.Controls[i + 1] as TextBox;

                    if(tb.Text!="")
                    {
                        if(rb.Checked)
                        {
                            ans += "+" + tb.Text + ";";
                            loog = loog & true;

                        }else
                        {
                            ans += "-" + tb.Text + ";";
                        }
                        caunter++;
                    }

                }

                if (caunter < 2)
                {
                    loog = loog & false;
                }
            }
            else if (Information.taupOfTest == 2)
            {
                for (int i = 0; i < splitContainer3.Panel2.Controls.Count; i += 2)
                {
                    CheckBox cb = splitContainer3.Panel2.Controls[i] as CheckBox;
                    TextBox tb = splitContainer3.Panel2.Controls[i + 1] as TextBox;

                    if (tb.Text != "")
                    {
                        if (cb.Checked)
                        {
                            ans += "+" + tb.Text + ";";
                            loog = loog & true;

                        }
                        else
                        {
                            ans += "-" + tb.Text + ";";
                        }

                        caunter++;
                    }
                    
                }
                if (caunter < 2)
                {
                    loog = loog & false;
                }
            }
            else if(Information.taupOfTest == 3)
            {
                TextBox tb = splitContainer3.Panel2.Controls[0] as TextBox;
                if(tb.Text!="")
                {
                    ans += tb.Text + ";";
                    loog = loog & true;
                }     

            }else if(Information.taupOfTest==4)
            {
                for (int i = 0; i < splitContainer3.Panel2.Controls.Count; i += 2)
                {
                    TextBox tb1 = splitContainer3.Panel2.Controls[i] as TextBox;
                    TextBox tb2 = splitContainer3.Panel2.Controls[i + 1] as TextBox;

                    if (tb1.Text != "" && tb2.Text != "")
                    {
                        ans += tb1.Text + "&" + tb2.Text + ";";
                        loog = loog & true;

                        caunter++;
                    }
                    
                }
                if (caunter < 2)
                {
                    loog = loog & false;
                }
            }
            if (!loog)
            {
                MessageBox.Show("вы не вели ответов",
                   "ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
                return;
            }

            MessageBox.Show(ans);

            ClassQuestion question = new ClassQuestion(textBox1.Text, Information.taupOfTest, ans);
            listBox1.Items.Add(textBox1.Text);
            listQuestions.Add(question);
            cauntQechon++;
            toolStripStatusNumberOfQuestions.Text = "вопросов всего:" + Convert.ToString(cauntQechon);
            splitContainer3.Panel2.Controls.Clear();
            textBox1.Text = "";
            save = false;
        }

        private void сохранитьТэстToolStripMenuItem_Click(object sender, EventArgs e)//сохранить тэст
        {
            SqlConnection connection = new SqlConnection(Information.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;                                             
            string commandString;                                  
            string nameTable = Information.nameTest+"_"+Information.idTicer.ToString();
            try
            {
                commandString = "CREATE TABLE " + nameTable +
                    "([ID_question] INT IDENTITY(1,1) NOT NULL PRIMARY KEY," +
                    "[Text_question] nvarchar(100) NOT NULL," +
                    "[Type_question] int NOT NULL," +
                    "[Answers] nvarchar(100) NOT NULL)";
                command.CommandText = commandString;
                command.ExecuteNonQuery();


            }
            catch
            {
                DialogResult result = MessageBox.Show("такой тэст уже существует, переименовать?",
                     "уже существует",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question
                     );

                if (result == DialogResult.Yes)
                {
                    InputBox.InputBox inputBox = new InputBox.InputBox("Название", "Введите название тэста");
                    Information.nameTest = inputBox.getString();
                    сохранитьТэстToolStripMenuItem_Click(null, null);
                }
                else
                {
                    connection.Close();
                    return;
                }
            }

            commandString = "";

            command.CommandText = commandString;

            foreach (ClassQuestion item in listQuestions) //Перебрать все элементы списка
            {
                commandString = "INSERT INTO " + nameTable +
                    "([Text_question], [Type_question],[Answers]) " +
                    "VALUES('" + item.textQuestion + "','" + item.typeQuestion + "','" + item.answers +"') ";
                command = new SqlCommand(commandString, connection);
                //command.CommandText = commandString;
                command.ExecuteNonQuery();
            }

            commandString = "INSERT INTO Tests " +
                "([idTicher], [NameTest], [DataCreate])" +
                "VALUES('" + Information.idTicer + "','" + Information.nameTest + "','" + DateTime.Now + "') ";            
            command.CommandText = commandString;
            command.ExecuteNonQuery();
            MessageBox.Show("тэст успешно сахранён",
                     "успех",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                     );

            connection.Close();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)//добавить вопрос
        {
            if (save == false)
            {
                TypeOfQuestion question = new TypeOfQuestion();
                question.ShowDialog();

                int cauntAnswer = 4;

               
                curentQechon++;
                toolStripStatusNumber.Text = "№вопроса: " + Convert.ToString(curentQechon);

                splitContainer3.Panel2.Controls.Clear();

                if (Information.taupOfTest == 1)
                {
                    save = true;
                    toolStripStatusTape.Text += ": один ответ";
                    toolStripStatusNumberOfQuestions.Text = "вопросов всего:" + Convert.ToString(cauntQechon);
                    for (int i = 0; i < cauntAnswer; i++)
                    {
                        Information.RadioButtonDynamic(splitContainer3.Panel2, 20, 40 + i * 30 + i * 10, 30, 30);
                        Information.TextBoxDynamic(splitContainer3.Panel2, 60, 40 + i * 30 + i * 10, splitContainer3.Panel2.Width - 70, 30);
                        needIt = i + 1;
                    }
                }
                else if (Information.taupOfTest == 2)
                {
                    save = true;
                    toolStripStatusTape.Text += ": несколько ответов";
                    toolStripStatusNumberOfQuestions.Text = "вопросов всего:" + Convert.ToString(cauntQechon);
                    for (int i = 0; i < cauntAnswer; i++)
                    {
                        Information.CheckBoxDynamic(splitContainer3.Panel2, 20, 40 + i * 30 + i * 10, 30, 30);
                        Information.TextBoxDynamic(splitContainer3.Panel2, 60, 40 + i * 30 + i * 10, splitContainer3.Panel2.Width - 70, 30);
                        needIt = i + 1;
                    }
                }
                else if (Information.taupOfTest == 3)
                {
                    save = true;
                    toolStripStatusTape.Text += ": ввод ответа";
                    toolStripStatusNumberOfQuestions.Text = "вопросов всего:" + Convert.ToString(cauntQechon);
                    Information.TextBoxDynamic(splitContainer3.Panel2, 30, 40 + 30 + 10, splitContainer3.Panel2.Width - 70, 30);
                }
                else if (Information.taupOfTest == 4)
                {
                    save = true;
                    int a = splitContainer3.Panel2.Width / 2;
                    toolStripStatusTape.Text += ": соответствие";
                    toolStripStatusNumberOfQuestions.Text = "вопросов всего:" + Convert.ToString(cauntQechon);
                    for (int i = 0; i < cauntAnswer; i++)
                    {
                        Information.TextBoxDynamic(splitContainer3.Panel2, 10, 40 + i * 30 + i * 10, a, 30);
                        Information.TextBoxDynamic(splitContainer3.Panel2, a + 30, 40 + i * 30 + i * 10, a - 45, 30);
                        needIt = i + 1;
                    }
                }
            }else
            {
              DialogResult result =  MessageBox.Show("вы не сохранили вопрос, сохранить?",
                    "сохранить",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if(result==DialogResult.Yes)
                {
                    buttonSave_Click(null, null);
                }
            }
        }
    }
}
