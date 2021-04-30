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
    public partial class Frmstockreport : Form
    {
        public Frmstockreport()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            string sql = "select ProductID,ProductName,StockQuantity from Product";
            var data = dbconnection.GetTableByQuery(sql);
            grdlist.DataSource = data;
        }

        private void Frmstockreport_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
