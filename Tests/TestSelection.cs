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
    public partial class TestSelection : Form
    {
        public TestSelection()
        {
            InitializeComponent();
        }

        private void TestSelection_Load(object sender, EventArgs e)
        {
            dataGridViewTests.DataSource = this.testSelectionTableAdapter1.GetData();
            dataGridViewTests.Columns["idTest"].Visible = false;
            dataGridViewTests.Columns["idTicher"].Visible = false;
            dataGridViewTests.Columns["NameTest"].HeaderText = "Название";
            dataGridViewTests.Columns["nameTicher"].HeaderText = "Преподователь";
            dataGridViewTests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Information.idTest = (int)dataGridViewTests.CurrentRow.Cells["idTest"].Value;
            Information.idTicer = (int)dataGridViewTests.CurrentRow.Cells["idTicher"].Value;
            Information.nameTest = (string)dataGridViewTests.CurrentRow.Cells["NameTest"].Value;
            MessageBox.Show("вы приступили к работе над тэстом " + Information.nameTest + " id преподователя " + Convert.ToString(Information.idTicer));

            Testing testing = new Testing();

            testing.ShowDialog();
        }
    }
}
