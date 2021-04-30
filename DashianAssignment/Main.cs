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
   
    public partial class Main : Form
    {
        public bool IsLogOut;
        public Main()
        {
            InitializeComponent();
        }

        private void reportdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers f = new Suppliers();
            f.MdiParent = this;
            f.Show();
        }

        private void caterogyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category f = new Category();
            f.MdiParent = this;
            f.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items f = new Items();
            f.MdiParent = this;
            f.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase f = new Purchase();
            f.MdiParent = this;
            f.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales f = new Sales();
            f.MdiParent = this;
            f.Show();
        }

        private void damageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Damage f = new Damage();
            f.MdiParent = this;
            f.Show();
        }

        private void changeRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeRate f = new ChangeRate();
            f.MdiParent = this;
            f.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer f = new Customer();
            f.MdiParent = this;
            f.Show();
        }
    }
}
