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
    public partial class FrmPurchaseReport : Form
    {
        public FrmPurchaseReport()
        {
            InitializeComponent();
        }

        private void FrmPurchaseReport_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            string sql = "select PurchaseID,InvoiceNo,InvoiceAmount from Purchase where PurchaseDate between '" + dtfromdate.Value + "' and '" + dttodate.Value + "'";
            var data = dbconnection.GetTableByQuery(sql);
            grdlist.DataSource = data;
        }
        void CalculateTotal()
        {
            decimal sum = 0;
            for (int i = 0; i < grdlist.Rows.Count; i++)
            {
                sum = sum + Convert.ToDecimal(grdlist.Rows[i].Cells[2].Value);
            }
            txtinvoiceamount.Text = sum.ToString();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            LoadData();
            CalculateTotal();
        }
    }
}
