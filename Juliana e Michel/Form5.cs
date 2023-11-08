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
    public partial class frmex13 : Form
    {
        public frmex13()
        {
            InitializeComponent();
        }
        double areatotal;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcom.Clear();
            txtcomp.Clear();
            txtlarg.Clear();
            txtresult.Clear();

            lblresult.Text = "A area do cômodo é";
            areatotal = 0;
            txtcom.Focus();

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal principal = new frmprincipal();

            principal.Show();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double larg, comp, area;

            larg = Convert.ToDouble(txtlarg.Text);
            comp = Convert.ToDouble(txtcomp.Text);

            area = larg * comp;
            areatotal += larg * comp;
            txtresult.Text = area.ToString();

            var R = MessageBox.Show("Deseja continuar calculando?", "Continuar", MessageBoxButtons.YesNo);
            if(R == DialogResult.Yes)
            {
                txtcom.Clear();
                txtcomp.Clear();
                txtlarg.Clear();
                txtresult.Clear();
            }
            else
            {
                lblresult.Text = "area total";
                txtresult.Text = areatotal.ToString();
                txtcom.Clear();
                txtcomp.Clear();
                txtlarg.Clear();

            }
        }
    }
}
