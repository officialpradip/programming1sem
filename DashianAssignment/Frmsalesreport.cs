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
    public partial class Frmsalesreport : Form
    {
        public Frmsalesreport()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            string sql = "select SalesID,InvoiceNo,InvoiceAmount from Sales where SalesDate between '" + dtfromdate.Value + "' and '" + dttodate.Value + "'";
            var data = dbconnection.GetTableByQuery(sql);
            grdlist.DataSource = data;
        }

        private void Frmsalesreport_Load(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            LoadData();
            CalculateTotal();


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
    }
}
