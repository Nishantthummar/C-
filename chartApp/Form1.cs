using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChartDirector;

namespace chartApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                winChartViewer1.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show("Errpr");
            }

        }

        private void toolStripBtnZoomIn_Click(object sender, EventArgs e)
        {
            winChartViewer1.MouseUsage = WinChartMouseUsage.ZoomIn;
        }

        private void toolStripBtnZoomOut_Click(object sender, EventArgs e)
        {
            winChartViewer1.MouseUsage = WinChartMouseUsage.ZoomOut;
        }
    }

}
