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

namespace Tests
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Information.connectionString = Properties.Settings.Default.TestsConnectionString;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.ShowDialog();
        }

        private void buttonTesting_Click(object sender, EventArgs e)
        {
            StudentRegistration registration = new StudentRegistration();
            registration.ShowDialog();
        }
    }
}
