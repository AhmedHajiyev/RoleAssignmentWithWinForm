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

            groupBoxAdmin.Visible = false;
            groupBoxDelete.Visible = false;
            groupBoxUpdate.Visible = false;

            if (TxtUpdateID.Text == "11")
            {
                TxtEmail.Text = "admin@gmail.com";
                TxtEmail.Enabled = false;
            }
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
            int id = Convert.ToInt32(TxtUpdateID.Text);
            var x = db.User_Info.Find(id);
            
            x.Username = TxtUserName.Text;
            x.Password = TxtPassWord.Text;
            x.Email = TxtEmail.Text;
            x.Create_ = checkBoxCreat.Checked;
            x.Update_ = checkBoxUpdate.Checked;
            x.Read_ = checkBoxUpdate.Checked;
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

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            groupBoxAdmin.Visible = true;
            groupBoxUpdate.Visible = false;
            groupBoxDelete.Visible = false;
            

        }

        

        private void BtnAdminUpdate_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(TxtAdminId.Text);
            var x = db.User_Info.Find(id);

            x.Username = TxtAdminUserName.Text;
            x.Password = TxtAdminPassWord.Text;

            db.SaveChanges();
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

            groupBoxAdmin.Visible = false;
           
        }

        private void BtnDeleteSeen_Click(object sender, EventArgs e)
        {
            groupBoxDelete.Visible = true;
            groupBoxUpdate.Visible = false;
            groupBoxAdmin.Visible = false;
        }

        private void BtnUpdateTrue_Click(object sender, EventArgs e)
        {
            groupBoxDelete.Visible = false;
            groupBoxUpdate.Visible = true;
            groupBoxAdmin.Visible = false;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            groupBoxDelete.Visible = false;
            groupBoxUpdate.Visible = false;
            groupBoxAdmin.Visible = false;
        }

        private void TxtUpdateID_TextChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
