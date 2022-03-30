using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTaxableIncome.Enabled = false;
            txtIncometaxowed.Enabled = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtIncometaxowed.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                return;
            }
            decimal TaxableIncome =
                Convert.ToDecimal(txtTaxableIncome.Text);

            double Incometaxowed;

            if (0 < TaxableIncome && TaxableIncome < 9225)
            {
                Incometaxowed = (TaxableIncome) * 0.1;
            }

            else if(9225 < TaxableIncome && TaxableIncome < 37450)
            {
                Incometaxowed = (Incometaxowed * 0.15) + 9225;
            }


            else if(37450 < TaxableIncome && TaxableIncome < 90750)
            {
                Incometaxowed = (Incometaxowed * 0.25) + 5156.25;
            }

            else if (90750 < TaxableIncome && TaxableIncome < 189300)
            {
                Incometaxowed = (Incometaxowed * 0.28) + 18481.25;
            }

            else if (189300 < TaxableIncome && TaxableIncome < 411500)
            {
                Incometaxowed = (Incometaxowed * 0.33) + 46075.25;
            }

            else if (411500 < TaxableIncome && TaxableIncome < 413200)
            {
                Incometaxowed = (Incometaxowed * 0.35) + 119401.25;
            }

            else if (413200 < TaxableIncome )
            {
                Incometaxowed = (Incometaxowed * 0.396) + 119996.25;
            }

            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtEnterName.TextLength == 0)
            {
                MessageBox.Show("Please enter your name again !");
            }
            else
            {
                MessageBox.Show("Enter name successfully!");
            }
        }

        private void txtTaxableIncome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtIncometaxowed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnterName_TextChanged(object sender, EventArgs e)
        {
            txtTaxableIncome.Enabled = true;
            txtIncometaxowed.Enabled = true;
        }

        private void btnCalculate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            } 
        }
    } 
}
