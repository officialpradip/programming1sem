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
    public partial class Product : Form
    {
        private bool IsEditMode = false;
        public Product()
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
                    btnsave.Enabled = false;
                    txtproductid.Clear();
                    txtproductname.Clear();
                    txtproductid.Enabled = true;
                    txtproductname.ReadOnly = true;
                    break;
                case "New"://setting when new is click
                    btnnew.Enabled = false;
                    btndelete.Enabled = false;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    txtproductid.Enabled = false;
                    txtproductid.ReadOnly = false;
                    txtproductname.Clear();
                    txtproductname.Clear();
                    break;
                case "Edit":
                    btnnew.Enabled = false;
                    btndelete.Enabled = true;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    txtproductid.Enabled = false;
                    txtproductname.ReadOnly = false;
                    break;

            }
        }
        private int GetProductId()//to generate product id
        {
            try
            {
                string Id = "SELECT max(ProductId)+1 as" + " Product from Product";
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
            
        }

        private void btnnew_Click_1(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
            txtproductid.Text = GetProductId().ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (IsEditMode == false)
            {
                string Sql = "Insert into Product(ProductID,ProductName,Unit,SellingPrice,CostPrice,StockQuantity) Values  ( " + txtproductid.Text + ",'" + txtproductname.Text + "', " + txtunit.Text + ", " + txtsellingprice.Text + ", " + txtcostprice.Text + ", " + txtstock.Text + ")";
                dbconnection.ExecuteNonQuery(Sql);
                MessageBox.Show("Successfully Saved");
                EnableDisableControl("Reset");
            }
            else
            {
                string UpdateSql = "update Product set ProductID= " + txtproductid.Text + ", ProductName='" + txtproductname.Text + "', Unit=" + txtunit.Text + ", SellingPrice=" + txtsellingprice.Text + ",CostPrice=" + txtcostprice.Text + ", StockQuantity=" + txtstock.Text + " where ProductID = " + txtproductid.Text + " ";
                dbconnection.ExecuteNonQuery(UpdateSql);
            }
            grdproductlist.DataSource = GetData();
        }
        private DataTable GetData()
        {
            string sql = "Select ProductID,ProductName,Unit,SellingPrice,CostPrice,StockQuantity from Product";
            return dbconnection.GetTableByQuery(sql);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("Edit");
        }
        public void Serialize() //function generate serial number
        {
            for (int i = 0; i < grdproductlist.Rows.Count; i++)
            {
                grdproductlist.Rows[0].Cells[0].Value = i + 1;
            }
        }
        private void LoadProduct()//function to load combo with dara of user
        {
            //query to select data from product
            string sql = "Select ProductID,ProductName,Unit,SellingPrice,CostPrice,StockQuantity";
            var datalist = dbconnection.GetTableByQuery(sql);  // execute command to sql 
            grdproductlist.DataSource = datalist;//assigning data to grid view
            Serialize();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            grdproductlist.DataSource = GetData();
        }

        private void grdproductlist_DoubleClick(object sender, EventArgs e)
        {
            txtproductid.Text = grdproductlist.CurrentRow.Cells["ProductID"].Value.ToString();
            txtproductname.Text = grdproductlist.CurrentRow.Cells["ProductName"].Value.ToString();
            txtunit.Text = grdproductlist.CurrentRow.Cells["Unit"].Value.ToString();
            txtsellingprice.Text = grdproductlist.CurrentRow.Cells["SellingPrice"].Value.ToString();
            txtcostprice.Text = grdproductlist.CurrentRow.Cells["CostPrice"].Value.ToString();

            txtstock.Text = grdproductlist.CurrentRow.Cells["StockQuantity"].Value.ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("reset");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string delstr = "delete from Product where ProductID= " + txtproductid.Text;
            var a = MessageBox.Show("do you confirm to delete", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                dbconnection.ExecuteNonQuery(delstr);
                MessageBox.Show("delete successfully");
                grdproductlist.DataSource = GetData();
            }
        }
    }

}
