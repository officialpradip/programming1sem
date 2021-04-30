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
    public partial class Suppliers : Form
    {
        private bool IsEditMode = false;
        public Suppliers()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private DataTable GetData()
        {
            string sql = "Select SupplierID,SupplierName,Address,Telephone,Remark from Supplier";
            return dbconnection.GetTableByQuery(sql);
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            grdsupplierlist.DataSource = GetData();
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
                    txtsupplierid.Clear();
                    txtsuppliername.Clear();
                    txtsupplierid.Enabled = true;
                    txtsuppliername.ReadOnly = true;
                    txtsupplierid.ReadOnly = false;
                    txtsuppliername.ReadOnly = false;
                    txtaddress.ReadOnly = false;
                    txtremark.ReadOnly = false;
                    txttelephone.ReadOnly = false;
                  //  txtsuppliername.Clear();
                    txtaddress.Clear();
                    txttelephone.Clear();
                    txtremark.Clear();
                    break;
                case "New"://setting when new is click
                    btnnew.Enabled = false;
                    btndelete.Enabled = false;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    txtsupplierid.Enabled = false;
                    txtsupplierid.ReadOnly = false;
                    txtsuppliername.Clear();
                   // txtsuppliername.Clear();
                    txtsupplierid.ReadOnly = false;
                    txtsuppliername.ReadOnly = false;
                    txtaddress.ReadOnly = false;
                    txtremark.ReadOnly = false;
                    txttelephone.ReadOnly = false;
                   // txtsuppliername.Clear();
                    txtaddress.Clear();
                    txttelephone.Clear();
                    txtremark.Clear();
                    break;
                case "Edit":
                    btnnew.Enabled = false;
                    btndelete.Enabled = true;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    txtsupplierid.Enabled = false;
                    txtsuppliername.ReadOnly = false;
                    txtsupplierid.ReadOnly = false;
                    txtsuppliername.ReadOnly = false;
                    txtaddress.ReadOnly = false;
                    txtremark.ReadOnly = false;
                    txttelephone.ReadOnly = false;
                    txtsuppliername.Clear();
                    txtaddress.Clear();
                    txttelephone.Clear();
                    txtremark.Clear();
                    break;

            }
        }
        private int GetSupplierId()//to generate supplier id
        {
            try
            {
                string Id = "SELECT max(SupplierId)+1 as" + " Supplier from Supplier";
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
            txtsupplierid.Text = GetSupplierId().ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (IsEditMode == false)
            {
                string Sql = "Insert into Supplier(SupplierID,SupplierName,Address,Telephone,Remark) Values  (" + txtsupplierid.Text + ",'" + txtsuppliername.Text + "','" + txtaddress.Text + "','" + txttelephone.Text + "','" + txtremark.Text + "')";
                dbconnection.ExecuteNonQuery(Sql);
                MessageBox.Show("Successfully Saved");
                EnableDisableControl("Reset");
            }
            else
            {
                string UpdateSql = "update Supplier set SupplierID = " + txtsupplierid.Text + ", SupplierName = '" + txtsuppliername.Text + "', Address='" + txtaddress.Text + "', Telephone= " + txttelephone.Text + ", Remark = '" + txtremark.Text + "' Where SupplierId =" + txtsupplierid.Text + "";
                dbconnection.ExecuteNonQuery(UpdateSql);
            }
            grdsupplierlist.DataSource = GetData();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("edit");
        }
        public void Serialize() //function generate serial number
        {
            for (int i = 0; i < grdsupplierlist.Rows.Count; i++)
            {
                grdsupplierlist.Rows[0].Cells[0].Value = i + 1;
            }
        }
        private void LoadCustomer()//function to load combo with dara of SUPPLIER
        {
            //query to select data from customer
            string sql = "select SupplierId,SupplierName,Address,Telephone,Remark from Supplier";
            var datalist = dbconnection.GetTableByQuery(sql);  // execute command to sql 
            grdsupplierlist.DataSource = datalist;//assigning data to grid view
            Serialize();
        }

        private void grdsupplierlist_DoubleClick(object sender, EventArgs e)
        {
            txtsupplierid.Text = grdsupplierlist.CurrentRow.Cells["SupplierID"].Value.ToString();
            txtsuppliername.Text = grdsupplierlist.CurrentRow.Cells["SupplierName"].Value.ToString();
            txtaddress.Text = grdsupplierlist.CurrentRow.Cells["Address"].Value.ToString();
            txttelephone.Text = grdsupplierlist.CurrentRow.Cells["Telephone"].Value.ToString();
            txtremark.Text = grdsupplierlist.CurrentRow.Cells["Remark"].Value.ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("reset");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string delstr = "delete from Supplier where SupplierID= " + txtsupplierid.Text;
            var a = MessageBox.Show("do you confirm to delete", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                dbconnection.ExecuteNonQuery(delstr);
                MessageBox.Show("delete successfully");
                grdsupplierlist.DataSource = GetData();
            }
        }
    }
}

   
    

