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
    public partial class frmex12 : Form
    {
        public frmex12()
        {
            InitializeComponent();
        }

        private void lblcelcius_Click(object sender, EventArgs e)
        {

        }

        private void txtcelcius_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnenquanto_Click(object sender, EventArgs e)
        {



        }

        private void frmex12_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcelsius.Clear();
            txtresult.Clear();

            txtcelsius.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmprincipal Menu = new frmprincipal();

            Menu.Show();
        }

        private void btnenquanto_Click_1(object sender, EventArgs e)
        {
            double I = 1, C, F;

            C = Convert.ToDouble(txtcelsius.Text);

            F = C * 1.8 + 32;

            while (I <= 10)
            {
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + C.ToString() + "=" + F.ToString());
                I++;
                C = C + 10;
                F = C * 1.8 + 32;

            }




        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            double I = 1, C, F;

            C = Convert.ToDouble(txtcelsius.Text);

            F = C * 1.8 + 32;

            do
            {
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + C.ToString() + "=" + F.ToString());
                I++;
                C = C + 10;
                F = C * 1.8 + 32;
            } while (I <= 10);
        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            double I, C, F;

            C = Convert.ToDouble(txtcelsius.Text);

            F = C * 1.8 + 32;

            for (I = 1; I <= 10; I++)
            {
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + C.ToString() + "=" + F.ToString());
                C = C + 10;
                F = C * 1.8 + 32;
            }
        }
    }
}