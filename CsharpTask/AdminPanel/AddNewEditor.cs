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
            MessageBox.Show("Editor Added");


        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
