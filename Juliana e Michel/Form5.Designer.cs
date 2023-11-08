
namespace Juliana_e_Michel
{
    partial class frmex13
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblcom = new System.Windows.Forms.Label();
            this.lblcomp = new System.Windows.Forms.Label();
            this.lbllarg = new System.Windows.Forms.Label();
            this.txtcom = new System.Windows.Forms.TextBox();
            this.txtlarg = new System.Windows.Forms.TextBox();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(42, 381);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(96, 41);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(552, 381);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(96, 41);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(679, 381);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(96, 41);
            this.btnvoltar.TabIndex = 4;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lblcom
            // 
            this.lblcom.AutoSize = true;
            this.lblcom.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcom.Location = new System.Drawing.Point(38, 49);
            this.lblcom.Name = "lblcom";
            this.lblcom.Size = new System.Drawing.Size(212, 21);
            this.lblcom.TabIndex = 5;
            this.lblcom.Text = "Digite o nome do cômodo";
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomp.Location = new System.Drawing.Point(38, 182);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(178, 21);
            this.lblcomp.TabIndex = 6;
            this.lblcomp.Text = "Digite o comprimento";
            // 
            // lbllarg
            // 
            this.lbllarg.AutoSize = true;
            this.lbllarg.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllarg.Location = new System.Drawing.Point(38, 123);
            this.lbllarg.Name = "lbllarg";
            this.lbllarg.Size = new System.Drawing.Size(128, 21);
            this.lbllarg.TabIndex = 7;
            this.lbllarg.Text = "Digite a largura";
            // 
            // txtcom
            // 
            this.txtcom.Location = new System.Drawing.Point(256, 49);
            this.txtcom.Name = "txtcom";
            this.txtcom.Size = new System.Drawing.Size(100, 20);
            this.txtcom.TabIndex = 8;
            // 
            // txtlarg
            // 
            this.txtlarg.Location = new System.Drawing.Point(172, 126);
            this.txtlarg.Name = "txtlarg";
            this.txtlarg.Size = new System.Drawing.Size(100, 20);
            this.txtlarg.TabIndex = 9;
            // 
            // txtcomp
            // 
            this.txtcomp.Location = new System.Drawing.Point(222, 185);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(100, 20);
            this.txtcomp.TabIndex = 10;
            this.txtcomp.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(202, 294);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(100, 20);
            this.txtresult.TabIndex = 11;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(38, 292);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(158, 20);
            this.lblresult.TabIndex = 12;
            this.lblresult.Text = "A area do cômodo é";
            // 
            // frmex13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.txtlarg);
            this.Controls.Add(this.txtcom);
            this.Controls.Add(this.lbllarg);
            this.Controls.Add(this.lblcomp);
            this.Controls.Add(this.lblcom);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Name = "frmex13";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblcom;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.Label lbllarg;
        private System.Windows.Forms.TextBox txtcom;
        private System.Windows.Forms.TextBox txtlarg;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label lblresult;
    }
}