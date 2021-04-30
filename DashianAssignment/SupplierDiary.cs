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
    public partial class SupplierDiary : Form
    {
        public SupplierDiary()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            string sql = "Select SupplierID,SupplierName,Address,Telephone from Supplier";
            var data = dbconnection.GetTableByQuery(sql);
            grdlist.DataSource = data;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        void SearchByName()
        {
            string sql = "Select*from Supplier where SupplierName like'" + txtsupplierid.Text + "%'";
            var data = dbconnection.GetTableByQuery(sql);
            grdlist.DataSource = data;
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            SearchByName();
        }

        private void txtsupplierid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchByName();
            }
            catch (Exception)
            {
                
            }
        }
    }
}
