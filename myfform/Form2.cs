using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtDebitCard.Enabled = false;
            txtCreditCard.Enabled = false;

        }

        bool male = true;
        bool female = false;
        bool debitCardStatus = false;
        bool creditCardStatus = false;
        private void radMale_CheckedChanged(object sender, EventArgs e)
        {
            male = true;
            female = false;
        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {
            female = true;
            male = false;
        }
        public static string name;
        public static string surname;
        public static string place;
        public static string birthdate;
        public static string gender;
        public static string creditNo;
        public static string debitNo;

        private void chkDebitCard_CheckedChanged(object sender, EventArgs e)
        {
            if (debitCardStatus == false)
            {
               // MessageBox.Show("Enter Debit number");
                txtDebitCard.Enabled = true;
                debitCardStatus = true;
                
            }
            else
            {
                txtDebitCard.Text = "";
                txtDebitCard.Enabled = false;
                debitCardStatus = false;
            }
            
        }
        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (creditCardStatus == false)
            {

               // MessageBox.Show("Enter Credit number");
                txtCreditCard.Enabled = true;
                creditCardStatus = true;
               
                
            }
            else
            {
                txtCreditCard.Text = "";
                txtCreditCard.Enabled = false;
                creditCardStatus = false;

            }
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(male)
            {
               // MessageBox.Show("Gender: Male");
                gender = "Male";
            }
            else
            {
                //MessageBox.Show("Gender: Female");
                gender = "Female";
            }
            name = txtName.Text;
            surname = txtSurname.Text;
            place = comboBox1.Text;
            creditNo = txtCreditCard.Text;
            debitNo = txtDebitCard.Text;
            birthdate = dateTimePicker1.Value.ToShortDateString();
            Form3 obj = new Form3();
            obj.ShowDialog();

        }

        private void toolTipSubmit_Popup(object sender, PopupEventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labFshow.Text = trackFrequency.Value.ToString();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Nishant Thummar");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtCreditCard.Text = "";
            txtDebitCard.Text = "";
            chkDebitCard.Checked = false;
            checkBox2.Checked = false;
            radMale.Checked = true;
            comboBox1.Text = "";
           
            
        }
    }
}
