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

namespace AdminPanel
{
    public partial class Editor_Page : Form
    {
        
        public Editor_Page()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BLBO57O\SQLEXPRESS;Initial Catalog=WinFormTask;Integrated Security=True");
            SqlCommand command = new SqlCommand("Select * From Customers ", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            groupBoxAdd.Visible = false;
            groupBoxUpdate.Visible = false;


            BtnAddNewCustomer.Enabled = true;
        }

        WinFormTaskEntities db = new WinFormTaskEntities();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Name = TxtName.Text;
            c.Email = TxtEmail.Text;
            c.Phone = TxtPhone.Text;
            
            TxtName.Clear();
            TxtEmail.Clear();
            TxtPhone.Clear();
            db.Customers.Add(c);
            db.SaveChanges();
            DialogResult result =  MessageBox.Show("Customer Added");
            if (result == DialogResult.OK)
            {
                groupBoxAdd.Visible = false;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BLBO57O\SQLEXPRESS;Initial Catalog=WinFormTask;Integrated Security=True");
            SqlCommand command = new SqlCommand("Select * From Customers ", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnAddNewCustomer_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = true;
            groupBoxUpdate.Visible = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //TxtID.Text = index.ToString();
            int id = Convert.ToInt32(index.ToString());
            var x = db.Customers.Find(index);
            db.Customers.Remove(x);
            db.SaveChanges();
            DialogResult result = MessageBox.Show("Customer Deleted");
            


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxUpdate.Visible = true;
            groupBoxAdd.Visible = false;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtUpdateID.Text);
            var x = db.Customers.Find(id);

            x.Name = TxtUpdateName.Text;
            x.Email = TxtUpdateEmail.Text;
            x.Phone = TxtUpdatePhone.Text;
            
            db.SaveChanges();

            DialogResult result = MessageBox.Show("Customer Uptaded");
            if (result == DialogResult.OK)
            {
                groupBoxUpdate.Visible = false;
            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            groupBoxUpdate.Visible = false;

        }

        
    }
}
