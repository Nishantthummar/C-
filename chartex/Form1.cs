using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chartex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Second n1 = new Second();
            n1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["date"].Points.AddXY("ME", 33);
            this.chart1.Series["date"].Points.AddXY("QW", 23);
            this.chart1.Series["date"].Points.AddXY("AS", 56);
            this.chart1.Series["date"].Points.AddXY("ZX", 80);

            this.chart1.Series["who"].Points.AddXY("KL", 33);

            foreach( Form f in Application.OpenForms)
            {
                if(f is Second)
                {
                   
                    f.Focus();
                    return;
                }
            }

        }
    }
}
