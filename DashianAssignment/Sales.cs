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
    public partial class Sales : Form
    {
        private bool IsEditMood = false;
        public Sales()
        {
            InitializeComponent();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            IsEditMood = false;
            EnableDisableControl("New");
            txtsalesid.Text = GetSalesId().ToString();
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
                    

                    break;
                case "New"://setting when new is click
                    btnnew.Enabled = false;
                    btndelete.Enabled = false;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;

                    break;
                case "Edit":
                    btnnew.Enabled = false;
                    btndelete.Enabled = true;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;

                    break;

            }
        }
        private int GetSalesId()//to generate sales id
        {
            try
            {
                string Id = "SELECT max(SalesId)+1 as" + " Sales from Sales";
                var data = dbconnection.GetTableByQuery(Id);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            LoadCustomerCombo();
            LoadProductCombo();
        }
        private void LoadCustomerCombo()
        {
            string sql = "select CustomerId,CustomerName From Customer";
            var data = dbconnection.GetTableByQuery(sql);
            cmbcustomerid.DataSource = data;
            cmbcustomerid.DisplayMember = "CustomerName";
            cmbcustomerid.ValueMember = "CustomerId";
        }
        private void LoadProductCombo()
        {
            string sql = "select ProductId,ProductName From Product";
            var data = dbconnection.GetTableByQuery(sql);
            cmbproductid.DataSource = data;
            cmbproductid.DisplayMember = "ProductName";
            cmbproductid.ValueMember = "ProductId";
        }

        private void cmbproductid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select SellingPrice from Product where ProductId=" + cmbproductid.SelectedValue;
                var data = dbconnection.GetTableByQuery(sql);
                txtsalesrate.Text = Convert.ToDecimal(data.Rows[0][0]).ToString();
            }
            catch (Exception ex)
            {
                txtsalesrate.Text = "0";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var a = AddDuplicateItem(Convert.ToInt32(cmbproductid.SelectedValue), Convert.ToInt32(txtquantity.Text));
            if (a == true)
            {
                grdsaleslist.Rows.Add(0, cmbproductid.SelectedValue, cmbproductid.Text, txtquantity.Text, txtsalesrate.Text, Convert.ToDecimal(txtquantity.Text) * Convert.ToDecimal(txtsalesrate.Text));
                Serialize();
                 CalculateTotal();
            }
            CalculateTotal();
        }
        private bool AddDuplicateItem(int ID, int Quantity)
        {
            int i;
            if (grdsaleslist.Rows.Count > 0)
            {
                for (i = 0; i < grdsaleslist.Rows.Count; i++)
                {
                    if (grdsaleslist.Rows[i].Cells["SalesID"].Value.ToString() == ID.ToString())
                    {
                        grdsaleslist.Rows[i].Cells["Quantity"].Value = Convert.ToInt32(grdsaleslist.Rows[i].Cells["Quantity"].Value) + Quantity;
                        grdsaleslist.Rows[i].Cells["Total"].Value = Convert.ToInt32(grdsaleslist.Rows[i].Cells["Quantity"].Value) * Convert.ToInt32(grdsaleslist.Rows[i].Cells["SalesRate"].Value);
                        return false;
                    }
                }
            }
            return true;
        }
        public void Serialize() //function generate serial number
        {
            for (int i = 0; i < grdsaleslist.Rows.Count; i++)
            {
                grdsaleslist.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void grdsaleslist_DoubleClick(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("are you sure", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                grdsaleslist.Rows.Remove(grdsaleslist.CurrentRow);
                CalculateTotal();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int i;
            if (IsEditMood == false)
            {

                string Sql = "Insert into Sales(SalesID,InvoiceNo,CustomerID,SalesDate,InvoiceAmount,Remarks) Values  (" + txtsalesid.Text + ", " + txtinvoiceno.Text + " , " + cmbcustomerid.SelectedValue + " , '" + dtpicker.Value + "' , " + txtinvoiceamount.Text + " ,'" + txtremarks.Text + "')";
                dbconnection.ExecuteNonQuery(Sql);
                for (i = 0; i < grdsaleslist.RowCount; i++)
                {
                    string sqlInsert = "Insert into SalesDetails(SalesID,ProductID,SalesRate,Quantity) values(" + txtsalesid.Text + "," + grdsaleslist.Rows[i].Cells["ProductID"].Value + "," + grdsaleslist.Rows[i].Cells["SalesRate"].Value + "," + grdsaleslist.Rows[i].Cells["Quantity"].Value + ")";
                    //string sqlInsert="Insert into Purchase info(PurchaseID,ProductID,PurchaseRate,Quantity) Values (" + txtpurchaseid.Text + "," + grdpurchaselist.Rows[i].Cells["ProductID"].Value + "," + grdpurchaselist.Rows[i].Cells["PurchaseRate"].Value + "," + grdpurchaselist.Rows[i].Cells["Quantity"].Value + ")";
                    dbconnection.ExecuteNonQuery(sqlInsert);
                    updatestockAdd(Convert.ToInt32(grdsaleslist.Rows[i].Cells["ProductID"].Value), Convert.ToInt32(grdsaleslist.Rows[i].Cells["Quantity"].Value));
                }
                MessageBox.Show("Successfully Saved");
                EnableDisableControl("Reset");
            }
            else
            {
                string updatestr = "update Purchase set InvoiceNo='" + txtinvoiceno.Text + "',SupplierId=" + cmbcustomerid.SelectedValue + ",PurchaseDate='" + dtpicker + ",InvoiceAmount=" + txtinvoiceamount.Text + ",Remarks='" + txtremarks.Text + "' where PurchaseID=" + txtsalesid.Text;
                dbconnection.ExecuteNonQuery(updatestr);
                for (i = 0; i < grdsaleslist.Rows.Count; i++)
                {
                    updatestockSubtract(Convert.ToInt32(grdsaleslist.Rows[i].Cells["ProductID"].Value), Convert.ToInt32(grdsaleslist.Rows[i].Cells["Quantity"].Value));
                }
                string delstr = "delete from PurchaseDetails where PurchaseID=" + txtsalesid.Text;
                dbconnection.ExecuteNonQuery(delstr);

                for (i = 0; i < grdsaleslist.RowCount; i++)
                {
                    string sqlInsert = "Insert into PurchaseDetails(PurchaseID,ProductID,PurchaseRate,Quantity) values(" + txtsalesid.Text + "," + grdsaleslist.Rows[i].Cells["ProductID"].Value + "," + grdsaleslist.Rows[i].Cells["PurchaseRate"].Value + "," + grdsaleslist.Rows[i].Cells["Quantity"].Value + ")";
                    //string sqlInsert="Insert into Purchase info(PurchaseID,ProductID,PurchaseRate,Quantity) Values (" + txtpurchaseid.Text + "," + grdpurchaselist.Rows[i].Cells["ProductID"].Value + "," + grdpurchaselist.Rows[i].Cells["PurchaseRate"].Value + "," + grdpurchaselist.Rows[i].Cells["Quantity"].Value + ")";
                    dbconnection.ExecuteNonQuery(sqlInsert);
                    MessageBox.Show("Successfully Saved");
                    EnableDisableControl("Reset");
                }
            }

        }

        void CalculateTotal()
        {
            decimal sum = 0;
            for (int i = 0; i < grdsaleslist.Rows.Count; i++)
            {
                sum = sum + Convert.ToDecimal(grdsaleslist.Rows[i].Cells[5].Value);
            }
            txtinvoiceamount.Text = sum.ToString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string sql = "Select*from Sales where SalesID=" + txtsalesid.Text;
            DataTable dt = dbconnection.GetTableByQuery(sql);
            if (dt.Rows.Count > 0)
            {
                txtinvoiceno.Text = dt.Rows[0]["InvoiceNo"].ToString();
                dtpicker.Value = Convert.ToDateTime(dt.Rows[0]["SalesDate"]);
                cmbcustomerid.SelectedValue = Convert.ToInt32(dt.Rows[0]["CustomerID"]);
                txtinvoiceamount.Text = Convert.ToDecimal(dt.Rows[0]["InvoiceAmount"]).ToString();
                txtremarks.Text = Convert.ToString(dt.Rows[0]["Remarks"]);

            }
            string sqldetail = "Select PurchaseID,p.productName,pd.productID,pd.PurchaseRate,Quantity,PurchaseRate *Quantity as Total from PurchaseDetails pd " + "inner join Product P on pd.ProductID=p.productID where pd.purchaseID=" + txtsalesid.Text;
            var data = dbconnection.GetTableByQuery(sqldetail);
            grdsaleslist.DataSource = data;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            IsEditMood = true;
            EnableDisableControl("Edit");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string deleteSales = "Delete from Sales Where SalesID=" + txtsalesid.Text;
            dbconnection.ExecuteNonQuery(deleteSales);
            string delSalesDetails = "delete from SalesDetails where SalesID=" + txtsalesid.Text;
            dbconnection.ExecuteNonQuery(delSalesDetails);
            MessageBox.Show("Successfully Deleted");
        }
        private void updatestockAdd(int ProductID, int StockQuantity)
        {
            string Searchstr = "select StockQuantity from Product where ProductID=" + ProductID;
            var data = dbconnection.GetTableByQuery(Searchstr);
            Int32 Stock = Convert.ToInt32(data.Rows[0][0]);
            Stock = Stock + StockQuantity;

            string sqlupdate = "update Product set StockQuantity=" + Stock + " where productid=" + ProductID;
            dbconnection.ExecuteNonQuery(sqlupdate);
        }
        private void updatestockSubtract(int ProductID, int StockQuantity)
        {
            string Searchstr = "select StockQuantity from Product where ProductID=" + ProductID;
            var data = dbconnection.GetTableByQuery(Searchstr);
            Int32 Stock = Convert.ToInt32(data.Rows[0][0]);
            Stock = Stock + StockQuantity;

            string sqlupdate = "update Product set StockQuantity=" + Stock + " where productid=" + ProductID;
            dbconnection.ExecuteNonQuery(sqlupdate);
        }

        private void cmbcustomerid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
    

