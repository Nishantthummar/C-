using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;

namespace DataHeader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        byte[] val = { 0xAA, 0x02, 0x07, 0x05, 0x01, 0x02, 0x03, 0xFF, 0x01, 0x02, 0x03, 0x04, 0x05, 0xff, 0xf1 };

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            header h1 = new header();
            string rx=  h1.Spiter(val);
            if(rx.Length < 120)
            {
                int zlen = 120 - rx.Length;
                int i;
                for(i=0; i<zlen; i++)
                {
                    rx = "0" + rx;
                }

               
            }
            
            int x = val.Length;
            byte was = val.ElementAt(0);
            richTextBox1.Text = rx;
            
            txtSensorId.Text =  (Convert.ToString(richTextBox1.TextLength));
            string datatype = rx.Substring(0, 8);
            string sensorid = rx.Substring(8, 8);
            string timestampusec = rx.Substring(16, 32);
            byte[] btt = Encoding.ASCII.GetBytes(datatype);
            Console.WriteLine(Encoding.ASCII.GetString(btt));

            txtDatatype.Text = timestampusec;
         }
        


    }
}
