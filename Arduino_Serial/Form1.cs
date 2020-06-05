using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Security.Cryptography;
using System.Threading;

namespace Arduino_Serial
{
    public partial class Serial_Com : Form
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        public Serial_Com()
        {
            InitializeComponent();
             int chartWidth = 773;
            int con = 50;

            hScrollBar1.Minimum = 250;
            hScrollBar1.Maximum = 10000;

            btnDisconnect.Enabled = false;
            btnConnect.Enabled = false;
            getAvailablePorts();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                    btnConnect.Enabled = true;
                }

            }
        }
        void getAvailablePorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {   
            if(!isConnected)
            {
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                connectToPort();
                MessageBox.Show("Connected", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread working = new Thread(serial_read);
                working.Start();
                
            }
        }

        private void connectToPort()
        {
            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            try
            {
                port.Open();
            }
            catch (Exception ex)
            {
                comboBox1.Text = "";
                getAvailablePorts();
                MessageBox.Show(Convert.ToString(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }
        private void disconnectToPort()
        {
            isConnected = false;
            try
            {
                port.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
              
                disconnectToPort();
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                MessageBox.Show("Disconnected", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void serial_read()
        {

            while (true)
            {
                try
                {
                    string rx_data = port.ReadLine();
                    labDisp.Text = rx_data;
                    chart1.Series["Value"].Points.AddY(rx_data);
                    Thread.Sleep(500);
                    
                }
                catch (Exception ex)
                {
                    break;
                   
                }

            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // chart1.Width = hScrollBar1.Value;
            //chart1.Move = hScrollBar1.Value;
            chart1.Width = hScrollBar1.Value;
                 
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
           // chart1.Width = chartWidth + con

        }
    }
}
