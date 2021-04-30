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
    public partial class CustomerDiary : Form
    {
        public CustomerDiary()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            string sql = "select CustomerID,CustomerName,Address,Telephone from Customer";
            var data = dbconnection.GetTableByQuery(sql);
            grdlist.DataSource = data;
        }

        private void CustomerDiary_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            LoadData();
            //CalculateTotal();
        }
        void SearchByName()
        {
            string sql = "Select*from Supplier where SupplierName like'" + txtcustomer.Text + "%'";
            var data = dbconnection.GetTableByQuery(sql);
            grdlist.DataSource = data;
        }

        private void txtcustomer_TextChanged(object sender, EventArgs e)
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
