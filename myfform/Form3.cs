using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myfform
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            labF3Name.Text = Form2.name;
            labF3Surname.Text = Form2.surname;
            labF3Gender.Text = Form2.gender;
            labF3Dob.Text = Form2.birthdate;
            labF3Debit.Text = Form2.debitNo;
            labF3Credit.Text = Form2.creditNo;
            labF3Place.Text = Form2.place;


        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close(object sender, MouseEventArgs e)
        {

        }
    }
}
