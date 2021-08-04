using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdminPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            WinFormTaskEntities db = new WinFormTaskEntities();
            if (userName.Text == "admin" && passWord.Text == "admin")
            {
                AdminPage form2 = new AdminPage();
                form2.ShowDialog();
            }
            else
            {
                message.Text = "You have entered an invalid username or password";
            }
            


        }

    }
}
