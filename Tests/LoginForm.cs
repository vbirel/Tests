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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }        

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var rec = this.ticherTableAdapter1.GetData();
            this.dataGridView1.DataSource = rec;
            this.textBoxPas.UseSystemPasswordChar = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string log=this.textBoxLog.Text, pas=this.textBoxPas.Text;
            var rec = this.ticherTableAdapter1.GetData();
            var filter = rec.Where(p => p.login == log && p.password == pas);
            if(filter.Count()==0)
            {
                MessageBox.Show(
                    "неверное имя или пароль",
                    "ОШИБКА",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }else
            {
                Information.idTicer = filter.ElementAt(0).idTicher;
                Information.nameTicher = filter.ElementAt(0).nameTicher;
                MessageBox.Show(
                   "вы вошли как " + Information.nameTicher,
                   "успешно",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
                   );
                //MainMenu main = new MainMenu();
                ////main.toolStripStatusLabel1.Text = "вы вошли как " + Information.nameTicher;
                this.Hide();
                CreateTest test = new CreateTest();
                test.ShowDialog();
            }

        }

      

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registreyt reg = new Registreyt();
            this.Close();
         
            reg.ShowDialog();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                this.textBoxPas.UseSystemPasswordChar = false;
            }else
            {
                this.textBoxPas.UseSystemPasswordChar = true;
            }
        }
    }
}
