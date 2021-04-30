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
    public partial class Splash : Form
    {
        private double _cntr = 0;
        public bool showLoginForm { get; set; }
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_cntr < 1)
            {
                _cntr += 0.01;
                progressBar1.Value = Convert.ToInt32(_cntr * 100);
            }
            else
            {
                timer1.Stop();
                showLoginForm = true;
                this.Close();
            }
            if (timer1.Interval == 10 && _cntr * 100 >= 60) ;
            {
                progressBar1.Text = @"Loading Completed.. Starting Program..";
                progressBar1.Refresh();
            }
        }

      

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
