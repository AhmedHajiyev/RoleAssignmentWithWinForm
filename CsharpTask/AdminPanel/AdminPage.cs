using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;


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

            groupBoxUpdate.Visible = false;

            
        }

        WinFormTaskEntities db = new WinFormTaskEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewEditor addNewEditor = new AddNewEditor();
            addNewEditor.ShowDialog();
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
            checkBoxRead.Checked = true;
            checkBoxRead.Enabled = false;
            if (checkBoxCreat.Checked == false)
            {
                checkBoxRead.Checked = false;
                checkBoxRead.Enabled = true;
            }
            checkBoxRead.Checked = true;
            checkBoxRead.Enabled = false;
            if (checkBoxDelete.Checked == false)
            {
                checkBoxRead.Checked = false;
                checkBoxRead.Enabled = true;
            }
            checkBoxRead.Checked = true;
            checkBoxRead.Enabled = false;
            if (checkBoxUpdate.Checked == false)
            {
                checkBoxRead.Checked = false;
                checkBoxRead.Enabled = true;
            }
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
            groupBoxUpdate.Visible = false;


            int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //TxtID.Text = index.ToString();
            int id = Convert.ToInt32(index.ToString());
            if (db.User_Info.Where(r => r.Email == "admin@gmail.com").Count() > 0)
            {
                MessageBox.Show("You cannot delete the Admin");
            }
            else
            {

                var x = db.User_Info.Find(index);
                db.User_Info.Remove(x);
                db.SaveChanges();
                DialogResult result = MessageBox.Show($"{id} deleted");
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

        private void BtnUpdateTrue_Click(object sender, EventArgs e)
        {
            groupBoxUpdate.Visible = true;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            groupBoxUpdate.Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void TxtUpdateID_Leave(object sender, EventArgs e)
        {
            
            if (db.User_Info.Where(r => r.Email == "admin@gmail.com").Count() > 0)
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

        private void BtnRead_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = true;
            dataGridView1.Columns[6].Visible = true;
            dataGridView1.Columns[7].Visible = true;
            


        }

        private void checkBoxCreat_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxRead.Checked = true;
            checkBoxRead.Enabled = false;
            if (checkBoxCreat.Checked == false)
            {
                checkBoxRead.Checked = false;
                checkBoxRead.Enabled = true;
            }
            
        }

        private void checkBoxUpdate_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxRead.Checked = true;
            checkBoxRead.Enabled = false;
            if (checkBoxUpdate.Checked == false)
            {
                checkBoxRead.Checked = false;
                checkBoxRead.Enabled = true;
            }
        }

        private void checkBoxDelete_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxRead.Checked = true;
            checkBoxRead.Enabled = false;
            if (checkBoxDelete.Checked == false)
            {
                checkBoxRead.Checked = false;
                checkBoxRead.Enabled = true;
            }
        }
    }
}
