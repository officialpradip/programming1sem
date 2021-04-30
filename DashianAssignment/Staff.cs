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
    public partial class Staff : Form
    {
        private bool IsEditMode = false;
        public Staff()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void EnableDisableControl(string mode)
        {
            switch (mode)
            {
                case "Reset"://to reset form
                    btnnew.Enabled = true;
                    btndelete.Enabled = false;
                    btnedit.Enabled = true;
                    btnsave.Enabled = false;
                    txtstaffid.Clear();
                    txtstaffname.Clear();
                    txtstaffid.Enabled = true;
                    txtstaffname.ReadOnly = true;
                    txtstaffid.ReadOnly = false;
                    txtstaffname.ReadOnly = false;
                    txtstaffaddress.ReadOnly = false;
                    txtremark.ReadOnly = false;
                    txtphone.ReadOnly = false;
                    txtstaffaddress.Clear();
                    txtphone.Clear();
                    txtremark.Clear();
                    break;
                case "New"://setting when new is click
                    btnnew.Enabled = false;
                    btndelete.Enabled = false;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    txtstaffid.Enabled = false;
                    txtstaffid.ReadOnly = false;
                    txtstaffname.Clear();
                    txtstaffname.ReadOnly = false;
                    txtstaffaddress.ReadOnly = false;
                    txtremark.ReadOnly = false;
                    txtphone.ReadOnly = false;
                    txtstaffname.Clear();
                    txtstaffaddress.Clear();
                    txtphone.Clear();
                    txtremark.Clear();
                    break;
                case "Edit":
                    btnnew.Enabled = false;
                    btndelete.Enabled = true;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    txtstaffid.Enabled = false;
                    txtstaffname.ReadOnly = false;
                   
                    txtstaffaddress.ReadOnly = false;
                    txtremark.ReadOnly = false;
                    txtphone.ReadOnly = false;
                   // txtstaffname.Clear();
                  //  txtstaffaddress.Clear();
                  //  txtphone.Clear();
                  //  txtremark.Clear();
                    break;

            }
        }
        private int GetStaffId()//to generate staff
        {
            try
            {
                string Id = "SELECT max(StaffID)+1 as" + " Staff from Staff";
                var data = dbconnection.GetTableByQuery(Id);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
            txtstaffid.Text = GetStaffId().ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            bool s = txtisadmin.CheckState == CheckState.Checked ? true : false;
            if (IsEditMode == false)
            {
                string Sql = "Insert into Staff(StaffID,StaffName,StaffAddress,Phone,Username,UserPassword,Remark,IsAdmin) Values  ( "+ txtstaffid.Text +",'"+ txtstaffname.Text + "', '" + txtstaffaddress.Text + "', " + txtphone.Text + ", '" + txtusername.Text + "', '" + txtuserpassword.Text + "', '" + txtremark.Text + "', '" + s + "')";
                dbconnection.ExecuteNonQuery(Sql);
                MessageBox.Show("Successfully Saved");
                EnableDisableControl("Reset");
            }
            else
            {
                string UpdateSql = "update Staff set StaffID= " + txtstaffid.Text + ", StaffName='" + txtstaffname.Text + "', StaffAddress='" + txtstaffaddress.Text + "', Phone=" + txtphone.Text + ",Username='" + txtusername +"',UserPassword='" +txtuserpassword +"',Remark='" + txtremark.Text + "',IsAdmin='" + s +"' where StaffID = " + txtstaffid.Text + "";
                dbconnection.ExecuteNonQuery(UpdateSql);
            }
            grduserlist.DataSource = GetData();

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("Edit");
        }
        public void Serialize() //function generate serial number
        {
            for (int i = 0; i < grduserlist.Rows.Count; i++)
            {
                grduserlist.Rows[0].Cells[0].Value = i + 1;
            }
        }
        private void LoadStaff()//function to load combo with dara of user
        {
            //query to select data from user
            string sql = "select StaffID,StaffName,StaffAddress,Phone,Username,UserPassword,Remark,IsAdmin from Staff";
            var datalist = dbconnection.GetTableByQuery(sql);  // execute command to sql 
            grduserlist.DataSource = datalist;//assigning data to grid view
            Serialize();
        }
        private DataTable GetData()
        {
            string sql = "Select StaffID,StaffName,StaffAddress,Phone,Username,UserPassword,Remark,IsAdmin from Staff";
            return dbconnection.GetTableByQuery(sql);
        }

        private void User_Load(object sender, EventArgs e)
        {
            grduserlist.DataSource = GetData();
        }

        private void grduserlist_DoubleClick(object sender, EventArgs e)
        {
            txtstaffid.Text = grduserlist.CurrentRow.Cells["StaffID"].Value.ToString();
            txtstaffname.Text = grduserlist.CurrentRow.Cells["StaffName"].Value.ToString();
            txtstaffaddress.Text = grduserlist.CurrentRow.Cells["StaffAddress"].Value.ToString();
            txtphone.Text = grduserlist.CurrentRow.Cells["Phone"].Value.ToString();
            txtusername.Text = grduserlist.CurrentRow.Cells["Username"].Value.ToString();
            
            txtremark.Text = grduserlist.CurrentRow.Cells["Remark"].Value.ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("reset");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string delstr = "delete from Staff where StaffID= " + txtstaffid.Text;
            var a = MessageBox.Show("do you confirm to delete", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                dbconnection.ExecuteNonQuery(delstr);
                MessageBox.Show("delete successfully");
                grduserlist.DataSource = GetData();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    }

