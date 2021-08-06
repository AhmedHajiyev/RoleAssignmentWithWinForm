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
    public partial class AddNewEditor : Form
    {
        public AddNewEditor()
        {
            InitializeComponent();
        }

        WinFormTaskEntities db = new WinFormTaskEntities();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            User_Info user_Info = new User_Info();
            user_Info.Username = TxtUsername.Text;
            user_Info.Password = TxtPassword.Text;
            if(db.User_Info.Where(r => r.Email == "admin@gmail.com" && TxtEmail.Text == "admin@gmail.com").Count() > 0)
            {
                MessageBox.Show("Admin cannot be entered");
                TxtEmail.ForeColor =  System.Drawing.Color.Red;
            }
            else
            {

                user_Info.Email = TxtEmail.Text;
                user_Info.Create_ = checkBoxCreat.Checked;
                user_Info.Read_ = checkBoxRead.Checked;
                user_Info.Update_ = checkBoxUpdate.Checked;
                user_Info.Delete_ = checkBoxDelete.Checked;
                TxtUsername.Clear();
                TxtPassword.Clear();
                TxtEmail.Clear();
                db.User_Info.Add(user_Info);
                db.SaveChanges();
                DialogResult result = MessageBox.Show("Editor Added");
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }


        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void checkBoxCreat_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxRead.Checked = true;
            checkBoxRead.Enabled = false;
            if (checkBoxCreat.Checked == false )
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
