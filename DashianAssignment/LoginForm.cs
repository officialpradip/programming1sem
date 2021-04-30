using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashianAssignment
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
           txtLoginID.Text = "";
           txtPassword.Clear();
            txtLoginID.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var data =dbconnection.GetTableByQuery("Select * from Staff where UserName = '" + txtLoginID.Text.Trim() + "' and UserPassword= '" + txtPassword.Text.Trim() + "'");
            
            if (data.Rows.Count > 0)
            {
                CommonInfo.StaffID = (int)data.Rows[0]["StaffID"];
                CommonInfo.StaffName = data.Rows[0]["StaffName"].ToString();
                CommonInfo.UserName = data.Rows[0]["UserName"].ToString();
               // CommonInfo.IsAdmin= Convert.ToBoolean(data.Rows[0]["IsAdmin"]);
                CommonInfo.Password = txtPassword.Text;

                Close();
            }
            else
            {
                MessageBox.Show("Invalid Login");
                txtPassword.Focus();
                txtPassword.Select();
                //password error message
            }

        }
    }
}
