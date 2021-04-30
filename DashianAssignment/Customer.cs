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
    public partial class Customer : Form
    {
        private bool IsEditMode = false;
        public Customer()
        {
            InitializeComponent();
        }
        private void EnableDisableControl(string mode)
        {
            switch (mode)
            {
                case "Reset"://to reset form
                    btnnew.Enabled = true;
                    btndelete.Enabled = false;
                    btnedit.Enabled = true;
                    btnSave.Enabled = false;
                    //  txtcustomerid.Clear();
                    // txtcustomername.Clear();
                    //  txtcustomerid.Enabled = true;
                    //  txtcustomername.ReadOnly = true;
                    txtcustomerid.ReadOnly = false;
                    txtcustomername.ReadOnly = false;
                    txtaddress.ReadOnly = false;
                    txtremarks.ReadOnly = false;
                    txttelephone.ReadOnly = false;
                    txtcustomername.Clear();
                    txtaddress.Clear();
                    txttelephone.Clear();
                    txtremarks.Clear();

                    break;
                case "New"://setting when new is click
                    btnnew.Enabled = false;
                    btndelete.Enabled = false;
                    btnedit.Enabled = false;
                    btnSave.Enabled = true;
                    // txtcustomerid.Enabled = false;
                    // txtcustomerid.ReadOnly = false;
                    // txtcustomername.Clear();
                    // txtcustomername.Clear();
                    txtcustomername.ReadOnly = false;
                    txtaddress.ReadOnly = false;
                    txtremarks.ReadOnly = false;
                    txttelephone.ReadOnly = false;
                    txtcustomerid.Clear();
                    txtaddress.Clear();
                    txttelephone.Clear();
                    txtremarks.Clear();
                    break;
                case "Edit":
                    btnnew.Enabled = false;
                    btndelete.Enabled = true;
                    btnedit.Enabled = false;
                    btnSave.Enabled = true;
                   //txtcustomerid.Enabled = false;
                    txtcustomername.ReadOnly = false;
                    txtaddress.ReadOnly = false;
                    txtremarks.ReadOnly = false;
                    txttelephone.ReadOnly = false;
                    break;

            }
        }
        private int GetCustomerId()//to generate customer id
        {
            try
            {
                string Id = "SELECT max(CustomerId)+1 as" + " Customer from Customer";
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
            txtcustomerid.Text = GetCustomerId().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsEditMode == false)
            {
                string Sql = "Insert into Customer(CustomerID,CustomerName,Address,Telephone,Remarks) Values  (" + txtcustomerid.Text + ",'" + txtcustomername.Text + "','" + txtaddress.Text + "'," + txttelephone.Text + ",'" + txtremarks.Text + "')";
                dbconnection.ExecuteNonQuery(Sql);
                MessageBox.Show("Successfully Saved");
                EnableDisableControl("Reset");
            }
            else
            {
                string UpdateSql = "update Customer set CustomerID= " + txtcustomerid.Text + ", CustomerName='" + txtcustomername.Text + "', Address='" + txtaddress.Text + "', Telephone=" + txttelephone.Text + ",Remarks='" + txtremarks.Text + "' where CustomerID = " + txtcustomerid.Text + ""; 
                dbconnection.ExecuteNonQuery(UpdateSql);
            }
            grdcustomerlist.DataSource=GetData();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("edit");
        }
        public void Serialize() //function generate serial number
        {
            for(int i =0;i< grdcustomerlist.Rows.Count;i++)
            {
                grdcustomerlist.Rows[0].Cells[0].Value = i + 1;
            }
        }
        private void LoadCustomer()//function to load combo with dara of customer
        {
            //query to select data from customer
            string sql = "select CustomerId,CustomerName,Address,Telephone,Remarks from Customer";
            var datalist = dbconnection.GetTableByQuery(sql);  // execute command to sql 
            grdcustomerlist.DataSource = datalist;//assigning data to grid view
            Serialize();
        }
       private DataTable GetData()
        {
            string sql = "Select CustomerID,CustomerName,Address,Telephone,Remarks from Customer";
            return dbconnection.GetTableByQuery(sql);
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            grdcustomerlist.DataSource = GetData();
        }

        private void grdcustomerlist_DoubleClick(object sender, EventArgs e)
        {
            txtcustomerid.Text = grdcustomerlist.CurrentRow.Cells["CustomerID"].Value.ToString();
            txtcustomername.Text = grdcustomerlist.CurrentRow.Cells["CustomerName"].Value.ToString();
            txtaddress.Text = grdcustomerlist.CurrentRow.Cells["Address"].Value.ToString();
            txttelephone.Text = grdcustomerlist.CurrentRow.Cells["Telephone"].Value.ToString();
            txtremarks.Text = grdcustomerlist.CurrentRow.Cells["Remarks"].Value.ToString();
            
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("reset");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string delstr = "delete from Customer where CustomerID= " + txtcustomerid.Text;
            var a = MessageBox.Show("do you confirm to delete", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                dbconnection.ExecuteNonQuery(delstr);
                MessageBox.Show("delete successfully");
                grdcustomerlist.DataSource = GetData();
            }
        }
    }
}
