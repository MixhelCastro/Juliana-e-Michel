using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juliana_e_Michel
{
    public partial class frmex11 : Form
    {
        public frmex11()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmprincipal Menu = new frmprincipal();

            Menu.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();

            txtnum.Focus();
        }

        private void btnenquanto_Click(object sender, EventArgs e)
        {
            double num, result, I;

            num = Convert.ToDouble(txtnum.Text);

            I = 1;
            while (I < 10)
            {
                result = num * I;

                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + num.ToString() + " x " + I.ToString() + " = " + result.ToString());

                I++;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblfahrenheit_Click(object sender, EventArgs e)
        {

        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            double num, I, result;
            I = 1;
            do
            {
                num = Convert.ToDouble(txtnum.Text);
                result = num * I;

                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + num.ToString() + " x " + I.ToString() + " = " + result.ToString());

                I++;

            } while (I <= 10);
        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            double num, I, result;
            I = 1;
            for (I = 1; I <= 10; I++)
            {
                num = Convert.ToDouble(txtnum.Text);
                result = num * I;

                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + num.ToString() + " x " + I.ToString() + " = " + result.ToString());
            }
        }
    }
}















