
namespace Juliana_e_Michel
{
    partial class frmprincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio11 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblcria = new System.Windows.Forms.Label();
            this.criadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.criadorasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercicio11,
            this.exercicio12ToolStripMenuItem,
            this.exercicio13ToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // exercicio11
            // 
            this.exercicio11.Name = "exercicio11";
            this.exercicio11.Size = new System.Drawing.Size(180, 22);
            this.exercicio11.Text = "Tabuada";
            this.exercicio11.Click += new System.EventHandler(this.exercício11ToolStripMenuItem_Click);
            // 
            // exercicio12ToolStripMenuItem
            // 
            this.exercicio12ToolStripMenuItem.Name = "exercicio12ToolStripMenuItem";
            this.exercicio12ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercicio12ToolStripMenuItem.Text = "Tabela de °C para °F";
            this.exercicio12ToolStripMenuItem.Click += new System.EventHandler(this.exercicio12ToolStripMenuItem_Click);
            // 
            // exercicio13ToolStripMenuItem
            // 
            this.exercicio13ToolStripMenuItem.Name = "exercicio13ToolStripMenuItem";
            this.exercicio13ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercicio13ToolStripMenuItem.Text = "Verificador de área";
            this.exercicio13ToolStripMenuItem.Click += new System.EventHandler(this.exercicio13ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lblcria
            // 
            this.lblcria.AutoSize = true;
            this.lblcria.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcria.Location = new System.Drawing.Point(458, 363);
            this.lblcria.Name = "lblcria";
            this.lblcria.Size = new System.Drawing.Size(265, 35);
            this.lblcria.TabIndex = 1;
            this.lblcria.Text = "Juliana e Michel - Orientados pela Nivia <3";
            this.lblcria.Visible = false;
            this.lblcria.Click += new System.EventHandler(this.label1_Click);
            // 
            // criadorasToolStripMenuItem
            // 
            this.criadorasToolStripMenuItem.Name = "criadorasToolStripMenuItem";
            this.criadorasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.criadorasToolStripMenuItem.Text = "Criadoras";
            this.criadorasToolStripMenuItem.Click += new System.EventHandler(this.criadorasToolStripMenuItem_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(735, 407);
            this.Controls.Add(this.lblcria);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuMi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio11;
        private System.Windows.Forms.ToolStripMenuItem exercicio12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio13ToolStripMenuItem;
        private System.Windows.Forms.Label lblcria;
        private System.Windows.Forms.ToolStripMenuItem criadorasToolStripMenuItem;
    }
}

