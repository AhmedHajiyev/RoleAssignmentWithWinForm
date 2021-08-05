using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;



namespace AdminPanel
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void signIn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BLBO57O\SQLEXPRESS;Initial Catalog=WinFormTask;Integrated Security=True");
            SqlCommand command = new SqlCommand("Select * From User_Info ", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            connection.Open();
            command.Connection = connection;
            command.CommandText = "Select * From User_Info where Username=' " + userName.Text + "'And Password='" + passWord.Text + "'";
            SqlDataReader reader = command.ExecuteReader();

            WinFormTaskEntities db = new WinFormTaskEntities();
            if (userName.Text == "admin" && passWord.Text == "admin")
            {
                AdminPage form2 = new AdminPage();
                form2.ShowDialog();
            }
            else if (userName.Text == "test" && passWord.Text == "test")
            {
                Editor_Page form3 = new Editor_Page();
                form3.ShowDialog();
            }
            else
            {
                message.Text = "You have entered an invalid username or password";
            }
            


        }

    }
}
