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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exercício11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex11 Tabuada = new frmex11();
            Tabuada.Show();
        }

        private void exercicio12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex12 TabelaCF = new frmex12();
            TabelaCF.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblcria.Visible = false;
        }

        private void criadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblcria.Visible = true;
        }

        private void exercicio13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmex13 ex13 = new frmex13();
            ex13.Show();
        }
    }
}
