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

            groupBoxDelete.Visible = false;
            groupBoxUpdate.Visible = false;

            
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
            if (id == 11)
            {
                MessageBox.Show("You cannot delete the Admin");
            }
            else
            {

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

        

        

        

        private void BtnDeleteSeen_Click(object sender, EventArgs e)
        {
            groupBoxDelete.Visible = true;
            groupBoxUpdate.Visible = false;
        }

        private void BtnUpdateTrue_Click(object sender, EventArgs e)
        {
            groupBoxDelete.Visible = false;
            groupBoxUpdate.Visible = true;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            groupBoxDelete.Visible = false;
            groupBoxUpdate.Visible = false;
        }

        private void TxtUpdateID_Leave(object sender, EventArgs e)
        {
            if (TxtUpdateID.Text == "11")
            {
                TxtEmail.Text = "admin@gmail.com";
                TxtEmail.Enabled = false;
                checkBoxCreat.Checked = true;
                checkBoxUpdate.Checked = true;
                checkBoxRead.Checked = true;
                checkBoxDelete.Checked = true;
                checkBoxCreat.Enabled= false;
                checkBoxUpdate.Enabled = false;
                checkBoxRead.Enabled= false;
                checkBoxDelete.Enabled = false;
            }
            else
            {
                TxtEmail.Clear();
                TxtEmail.Enabled = true;
                checkBoxCreat.Checked = false;
                checkBoxUpdate.Checked = false;
                checkBoxRead.Checked = false;
                checkBoxDelete.Checked = false;
                checkBoxCreat.Enabled = true;
                checkBoxUpdate.Enabled = true;
                checkBoxRead.Enabled = true;
                checkBoxDelete.Enabled = true;
            }
        }

        
    }
}
