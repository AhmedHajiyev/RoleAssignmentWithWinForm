using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdminPanel
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BLBO57O\SQLEXPRESS;Initial Catalog=WinFormTask;Integrated Security=True");
            SqlCommand command = new SqlCommand("Select * From User_Info ", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        WinFormTaskEntities db = new WinFormTaskEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewEditor addNewEditor = new AddNewEditor();
            addNewEditor.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtID.Text);
            var x = db.User_Info.Find(id);
            db.User_Info.Remove(x);
            db.SaveChanges();
           DialogResult result =  MessageBox.Show("data silindi");
            if (result == DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BLBO57O\SQLEXPRESS;Initial Catalog=WinFormTask;Integrated Security=True");
                SqlCommand command = new SqlCommand("Select * From User_Info ", connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;

            }

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BLBO57O\SQLEXPRESS;Initial Catalog=WinFormTask;Integrated Security=True");
            SqlCommand command = new SqlCommand("Select * From User_Info ", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtID.Text);
            var x = db.User_Info.Find(id);
            x.Username = TxtUserName.Text;
            x.Email = TxtEmail.Text;
            x.Password = TxtPassWord.Text;
            x.Create_ = checkBoxCreat.Checked;
            x.Read_ = checkBoxRead.Checked;
            x.Update_ = checkBoxUpdate.Checked;
            x.Delete_ = checkBoxDelete.Checked;
            db.SaveChanges();
            
            DialogResult result =  MessageBox.Show("Updated");
            if (result == DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BLBO57O\SQLEXPRESS;Initial Catalog=WinFormTask;Integrated Security=True");
                SqlCommand command = new SqlCommand("Select * From User_Info ", connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
            }
        }

        
    }
}
