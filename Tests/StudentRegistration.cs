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
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testsDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.testsDataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testsDataSet.Teme". При необходимости она может быть перемещена или удалена.
            this.temeTableAdapter.Fill(this.testsDataSet.Teme);
            this.dataGridView1.DataSource = studentTableAdapter.GetData();

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Information.idTime = (int)this.comboBox1.SelectedValue;

            var rec = this.studentTableAdapter.GetData().Where(p => p.NameStudent == this.textBox1.Text && p.idTime == Information.idTime);            
                if(rec.Count()==0)
                {
                    try
                    {
                        this.studentTableAdapter.Insert(this.textBox1.Text, Information.idTime);
                       var recHelp = this.studentTableAdapter.GetData();
                        Information.idStudent = recHelp.Last().idStudent;
                        MessageBox.Show("Вы успешно зарегестририровались как " + textBox1.Text + "     Id группы " + Convert.ToString(Information.idTime));
                    }catch
                    {
                    MessageBox.Show(" Вас не удалось зарегистрировать в системе");
                    this.Close(); return;
                    }

                TestSelection test = new TestSelection();
                test.ShowDialog();
                }
            else
            {
                MessageBox.Show("вы вошли как " + textBox1.Text);
                TestSelection test = new TestSelection();
                test.ShowDialog();
            }
        }
    }
}
