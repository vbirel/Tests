using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class Registreyt : Form
    {
        public static string text = null;
        public Registreyt()
        {
            InitializeComponent();
        }

        private void Registreyt_Load(object sender, EventArgs e)
        {
           

           this.textBoxPasword1.UseSystemPasswordChar = true;
           this.textBoxPasword2.UseSystemPasswordChar = true;

            pictureBoxCapcha.Image = capcha(pictureBoxCapcha.Width, pictureBoxCapcha.Height, ref text);
        }

        private void buttonOk_Click(object sender, EventArgs e)//регистрация
        {
            if (check(this.textBoxName, this.textBoxPasword1, this.textBoxPasword2, this.textBoxLogin))
            {

                if (textBoxPasword1.Text == textBoxPasword2.Text)
                {
                    if (textBox1.Text != text)
                    {
                        MessageBox.Show(
                         "неправельная капча ",
                         "ошибка",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                         );
                    }
                    var rec = this.ticherTableAdapter1.GetData();
                    var filter = rec.Where(p => p.nameTicher == textBoxName.Text && p.login == textBoxLogin.Text);
                    if (filter.Count() == 0)
                    {
                        try
                        {
                            this.ticherTableAdapter1.Insert(textBoxLogin.Text, textBoxPasword2.Text, textBoxName.Text);
                            rec = this.ticherTableAdapter1.GetData();
                            Information.idTicer = rec.Last().idTicher;
                            Information.nameTicher = rec.Last().nameTicher;
                            MessageBox.Show(
                          "вы зарегистрировались как " + Information.nameTicher,
                          "успешно",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information
                          );

                            this.Hide();
                            CreateTest test = new CreateTest();
                            test.ShowDialog();
                        }
                        catch
                        {
                            MessageBox.Show(
                         "ПРОИЗОШЛА НЕПРЕДВИДДЕНАЯ ОШИБКА ",
                         "ОШИБКА",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                         );
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                         "Преподаватель с этим именем или логином уже существует ",
                         "ОШИБКА",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                         );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "вы не верно вели пароль",
                        "ОШИБКА",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

      private static Bitmap capcha(int width, int height, ref string text)//капча
        {
            Random rnd = new Random();

            
            Bitmap result = new Bitmap(width, height);

            
            int Xpos = rnd.Next(0, width - 50);
            int Ypos = rnd.Next(15, width - 15);

            
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green,
                     Brushes.White };

           
            Graphics g = Graphics.FromImage((Image)result);

            
            g.Clear(Color.Coral);

            
            
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            int cnr = rnd.Next(4, 7);
            for (int i = 0; i < cnr; ++i)
            {
                text += ALF[rnd.Next(ALF.Length)];
            }

            //for(int i=0; i<text.Length;i++)
            // {
            //     g.DrawString(text[i].ToString(),
            //             new Font("Arial", rnd.Next(12, 17)),
            //             colors[rnd.Next(0, 3)],
            //             new PointF(Xpos, Ypos));
            // }

            g.DrawString(text,
                         new Font("Arial", rnd.Next(10, 17)),
                         colors[rnd.Next(0, 3)],
                         new PointF(Xpos, Ypos));

            for (int i=0; i<8;i++)
            {
                g.DrawLine(Pens.Black,
                       new Point(rnd.Next(0,width-1), rnd.Next(0, height- 1)),
                       new Point(rnd.Next(0, width - 1), rnd.Next(0, height - 1)));
                g.DrawLine(Pens.Black,
                           new Point(rnd.Next(0, width - 1), rnd.Next(0, height - 1)),
                       new Point(rnd.Next(0, width - 1), rnd.Next(0, height - 1)));
            }

            //g.DrawLine(Pens.Black,
            //           new Point(0, 0),
            //           new Point(width - 1, height - 1));
            //g.DrawLine(Pens.Black,
            //           new Point(0, height - 1),
            //           new Point(width - 1, 0));
           
            for (int i = 0; i < width; ++i)
                for (int j = 0; j < height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void button1_Click(object sender, EventArgs e)//обнавление капчи
        {
            text = "";
            pictureBoxCapcha.Image= capcha(pictureBoxCapcha.Width, pictureBoxCapcha.Height, ref text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//видемость пароля
        {
            if(this.checkBox1.Checked)
            {
                textBoxPasword1.UseSystemPasswordChar = false;
                textBoxPasword2.UseSystemPasswordChar = false;
            }else
            {
                textBoxPasword1.UseSystemPasswordChar = true;
                textBoxPasword2.UseSystemPasswordChar = true;
            }
        }

        private static bool check(TextBox textBoxName, TextBox textBoxPasword1, TextBox textBoxPasword2, TextBox textBoxLogin)
        {


            if (textBoxName.Text == "")
            {
                MessageBox.Show(
                     "вы не ввели имя ",
                     "ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
                return false;
            }
            else if (textBoxPasword1.Text == "" && textBoxPasword2.Text == "")
            {
                MessageBox.Show(
                     "вы не ввели пароль ",
                     "ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
                return false;
            }
            else if (textBoxLogin.Text == "")
            {
                MessageBox.Show(
                     "вы не ввели логин ",
                     "ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                     );
                return false;
            }
            else
                return true;
        }
    }
}
