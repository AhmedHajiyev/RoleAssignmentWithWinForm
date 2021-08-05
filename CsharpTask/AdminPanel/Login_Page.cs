using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace AdminPanel
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        WinFormTaskEntities db = new WinFormTaskEntities();
        private void signIn_Click(object sender, EventArgs e)
        {



            //if (userName.Text == "admin" && passWord.Text == "admin")
            //{
            //    AdminPage form2 = new AdminPage();
            //    form2.ShowDialog();
            //}
            //else if (userName.Text == "test" && passWord.Text == "test")
            //{
            //    Editor_Page form3 = new Editor_Page();
            //    form3.ShowDialog();
            //}
            //else
            //{
            //    message.Text = "You have entered an invalid username or password";
            //}
            try
            {
                if (db.User_Info.Where(r=>r.Username==userName.Text && r.Password==passWord.Text && r.ID==11).Count()>0)
                {
                        AdminPage form2 = new AdminPage();
                        form2.ShowDialog();
                    
                }
                else if (db.User_Info.Where(r => r.Username == userName.Text && r.Password == passWord.Text && r.ID != 11).Count() > 0)
                {
                    Editor_Page form3 = new Editor_Page();




                    if (db.User_Info.Where(r => r.Username == userName.Text && r.Password == passWord.Text && r.Create_ == true).Count() > 0)
                    {
                        form3.BtnAddNewCustomer.Enabled = true;
                    }
                    else
                    {
                        form3.BtnAddNewCustomer.Enabled = false;
                    }

                    if (db.User_Info.Where(r => r.Username == userName.Text && r.Password == passWord.Text && r.Update_ == true).Count() > 0)
                    {
                        form3.BtnUpdateAndSeen.Enabled = true;
                    }
                    else
                    {
                        form3.BtnUpdateAndSeen.Enabled = false;
                    }
                    if (db.User_Info.Where(r => r.Username == userName.Text && r.Password == passWord.Text && r.Read_ == false).Count() > 0)
                    {
                        form3.BtnDelete.Visible = false;
                        form3.BtnUpdateAndSeen.Visible = false;
                        form3.BtnAddNewCustomer.Visible = false;
                        form3.BtnRefresh.Visible = false;
                        form3.BtnMin.Visible = false;
                        form3.dataGridView1.Visible = false;
                        form3.TxtMessage.Text = "You have no functionality";
                    }
                    if (db.User_Info.Where(r => r.Username == userName.Text && r.Password == passWord.Text && r.Delete_ == true).Count() > 0)
                    {
                        form3.BtnDelete.Enabled = true;
                    }
                    else
                    {
                        form3.BtnDelete.Enabled = false;
                    }
                    form3.ShowDialog();
                }
                else
                {
                    message.Text = "You have entered an invalid username or password";
                }


            }
            catch (Exception ert)
            {

            }
            


        }

        

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
