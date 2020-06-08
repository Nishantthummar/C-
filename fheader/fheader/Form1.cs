using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fheader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            byte[] val = { 0xAA, 0x02, 0x07, 0x05, 0x01, 0x02, 0x30, 0xFF, 0x01, 0x02, 0x03, 0x04, 0x05, 0xff, 0x00 };

            header h1 = new header();
            h1.spliter(val);
        }
    }
}
