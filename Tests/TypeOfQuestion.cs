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
    public partial class TypeOfQuestion : Form
    {
        public TypeOfQuestion()
        {
            InitializeComponent();
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Information.taupOfTest = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Information.taupOfTest = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Information.taupOfTest = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Information.taupOfTest = 4;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
