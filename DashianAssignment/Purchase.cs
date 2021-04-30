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
    public partial class Purchase : Form
    {
        private bool IsEditMode = false;
        public Purchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            LoadSupplierCombo();
            LoadProductCombo();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
                    txtpurchaseid.Clear();
                   
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
        private int GetPurchaseId()//to generate purchase id
        {
            try
            {
                string Id = "SELECT max(PurchaseId)+1 as" + " Purchase from Purchase";
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
            txtpurchaseid.Text = GetPurchaseId().ToString();
        }
        private void LoadSupplierCombo()
        {
            string sql = "select SupplierId,SupplierName From Supplier";
            var data = dbconnection.GetTableByQuery(sql);
            cmbsupplierid.DataSource = data;
            cmbsupplierid.DisplayMember = "SupplierName";
            cmbsupplierid.ValueMember = "SupplierId";
        }
        private void LoadProductCombo()
        {
            string sql = "select ProductId,ProductName From Product";
            var data = dbconnection.GetTableByQuery(sql);
            cmbproductid.DataSource = data;
            cmbproductid.DisplayMember = "ProductName";
            cmbproductid.ValueMember = "ProductId";
        }

        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbproductid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select CostPrice from Product where ProductId=" + cmbproductid.SelectedValue;
                var data = dbconnection.GetTableByQuery(sql);
                txtpurchaerate.Text = Convert.ToDecimal(data.Rows[0][0]).ToString();
            }
            catch (Exception ex)
            {
                txtpurchaerate.Text = "0";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var a = AddDuplicateItem(Convert.ToInt32(cmbproductid.SelectedValue), Convert.ToInt32(txtquantity.Text));
            if (a == true)
            {
                grdpurchaselist.Rows.Add(0, cmbproductid.SelectedValue, cmbproductid.Text, txtquantity.Text, txtpurchaerate.Text, Convert.ToDecimal(txtquantity.Text) * Convert.ToDecimal(txtpurchaerate.Text));
                Serialize();
               // CalculateTotal();
            }
            CalculateTotal();
        }
        private bool AddDuplicateItem(int ID,int Quantity)
        {
            int i;
            if (grdpurchaselist.Rows.Count>0)
            {
                for(i=0;i<grdpurchaselist.Rows.Count;i++)
                {
                    if(grdpurchaselist.Rows[i].Cells["ProductID"].Value.ToString()==ID.ToString())
                    {
                        grdpurchaselist.Rows[i].Cells["Quantity"].Value = Convert.ToInt32(grdpurchaselist.Rows[i].Cells["Quantity"].Value) + Quantity;
                        grdpurchaselist.Rows[i].Cells["Total"].Value = Convert.ToInt32(grdpurchaselist.Rows[i].Cells["Quantity"].Value) * Convert.ToInt32(grdpurchaselist.Rows[i].Cells["PurchaseRate"].Value);
                return false;
                    }
                }
            }
            return true;
        }
        public void Serialize() //function generate serial number
        {
            for (int i = 0; i < grdpurchaselist.Rows.Count; i++)
            {
                grdpurchaselist.Rows[i].Cells[0].Value = i + 1;
            }
        }
        
        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void grdpurchaselist_DoubleClick(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("are you sure", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                grdpurchaselist.Rows.Remove(grdpurchaselist.CurrentRow);
                CalculateTotal();
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            int i;
            if (IsEditMode == false)
            {
                
                string Sql = "Insert into Purchase(PurchaseID,InvoiceNo,SupplierID,PurchaseDate,InvoiceAmount,Remarks) Values  (" + txtpurchaseid.Text +", " + txtinvoiceno.Text + " , " + cmbsupplierid.SelectedValue + " , '" + dtpicker.Value + "' , " + txtinvoiceamount.Text + " ,'" + txtremarks.Text + "')";
                dbconnection.ExecuteNonQuery(Sql);
                for (i=0; i<grdpurchaselist.RowCount;i++)
                {
                    string sqlInsert = "Insert into PurchaseDetails(PurchaseID,ProductID,PurchaseRate,Quantity) values(" +txtpurchaseid.Text + "," + grdpurchaselist.Rows[i].Cells["ProductID"].Value + "," + grdpurchaselist.Rows[i].Cells["PurchaseRate"].Value + "," + grdpurchaselist.Rows[i].Cells["Quantity"].Value + ")";
                  //string sqlInsert="Insert into Purchase info(PurchaseID,ProductID,PurchaseRate,Quantity) Values (" + txtpurchaseid.Text + "," + grdpurchaselist.Rows[i].Cells["ProductID"].Value + "," + grdpurchaselist.Rows[i].Cells["PurchaseRate"].Value + "," + grdpurchaselist.Rows[i].Cells["Quantity"].Value + ")";
                    dbconnection.ExecuteNonQuery(sqlInsert);
                    updatestockAdd(Convert.ToInt32(grdpurchaselist.Rows[i].Cells["ProductID"].Value), Convert.ToInt32(grdpurchaselist.Rows[i].Cells["Quantity"].Value));
                    MessageBox.Show("Successfully Saved");
                    EnableDisableControl("Reset");
                }
              
            }
            else
            {
                string updatestr = "update Purchase set InvoiceNo='" + txtinvoiceno.Text + "',SupplierId=" + cmbsupplierid.SelectedValue + ",PurchaseDate='" + dtpicker + ",InvoiceAmount=" + txtinvoiceamount.Text + ",Remarks='" + txtremarks.Text + "' where PurchaseID=" + txtpurchaseid.Text;
                dbconnection.ExecuteNonQuery(updatestr);
                for (i = 0; i < grdpurchaselist.Rows.Count; i++)
                {
                    updatestockSubtract(Convert.ToInt32(grdpurchaselist.Rows[i].Cells["ProductID"].Value), Convert.ToInt32(grdpurchaselist.Rows[i].Cells["Quantity"].Value));
                }
                string delstr = "delete from PurchaseDetails where PurchaseID=" + txtpurchaseid.Text;
                dbconnection.ExecuteNonQuery(delstr);

                for (i = 0; i < grdpurchaselist.RowCount; i++)
                {
                    string sqlInsert = "Insert into PurchaseDetails(PurchaseID,ProductID,PurchaseRate,Quantity) values(" + txtpurchaseid.Text + "," + grdpurchaselist.Rows[i].Cells["ProductID"].Value + "," + grdpurchaselist.Rows[i].Cells["PurchaseRate"].Value + "," + grdpurchaselist.Rows[i].Cells["Quantity"].Value + ")";
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
            for (int i = 0; i < grdpurchaselist.Rows.Count; i++)
            {
                sum = sum + Convert.ToDecimal(grdpurchaselist.Rows[i].Cells[5].Value);
            }
            txtinvoiceamount.Text = sum.ToString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string sql = "Select*from Purchase where PurchaseID=" + txtpurchaseid.Text;
                DataTable dt = dbconnection.GetTableByQuery(sql);
            if(dt.Rows.Count>0)
            {
                txtinvoiceno.Text = dt.Rows[0]["InvoiceNo"].ToString();
                dtpicker.Value=Convert.ToDateTime(dt.Rows[0]["PurchaseDate"]);
                cmbsupplierid.SelectedValue = Convert.ToInt32(dt.Rows[0]["SupplierID"]);
                txtinvoiceamount.Text = Convert.ToDecimal(dt.Rows[0]["InvoiceAmount"]).ToString();
                txtremarks.Text = Convert.ToString(dt.Rows[0]["Remarks"]);

            }
            string sqldetail = "Select PurchaseID,p.productName,pd.productID,pd.PurchaseRate,Quantity,PurchaseRate *Quantity as Total from PurchaseDetails pd "+ "inner join Product P on pd.ProductID=p.productID where pd.purchaseID="+txtpurchaseid.Text;
            var data = dbconnection.GetTableByQuery(sqldetail);
            grdpurchaselist.DataSource = data;
        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("Edit");
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            string deletePurchase = "Delete from Purchase Where PurchaseID=" + txtpurchaseid.Text;
            dbconnection.ExecuteNonQuery(deletePurchase);
            string delPurchaseDetails = "delete from PurchaseDetails where PurchaseID=" + txtpurchaseid.Text;
            dbconnection.ExecuteNonQuery(delPurchaseDetails);
            MessageBox.Show("Successfully Deleted");
        }
        private void updatestockAdd(int ProductID,int StockQuantity)
        {
            string Searchstr = "select StockQuantity from Product where ProductID=" + ProductID;
            var data = dbconnection.GetTableByQuery(Searchstr);
            Int32 Stock = Convert.ToInt32(data.Rows[0][0]);
            Stock = Stock + StockQuantity;

            string sqlupdate="update Product set StockQuantity="+Stock + " where productid=" + ProductID;
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
    }

}
