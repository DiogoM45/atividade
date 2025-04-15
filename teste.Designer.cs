namespace devesaoDF
{
    partial class frmPrincipal
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
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtPrimeiro = new System.Windows.Forms.TextBox();
            this.txtSegundo = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiro
            // 
            this.lblPrimeiro.AutoSize = true;
            this.lblPrimeiro.Location = new System.Drawing.Point(63, 60);
            this.lblPrimeiro.Name = "lblPrimeiro";
            this.lblPrimeiro.Size = new System.Drawing.Size(89, 13);
            this.lblPrimeiro.TabIndex = 0;
            this.lblPrimeiro.Text = "Digite um número";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Location = new System.Drawing.Point(62, 133);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(99, 13);
            this.lblSegundo.TabIndex = 1;
            this.lblSegundo.Text = "Digite outro número";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(62, 208);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Resultado";
            // 
            // txtPrimeiro
            // 
            this.txtPrimeiro.Location = new System.Drawing.Point(244, 60);
            this.txtPrimeiro.Name = "txtPrimeiro";
            this.txtPrimeiro.Size = new System.Drawing.Size(100, 20);
            this.txtPrimeiro.TabIndex = 3;
            // 
            // txtSegundo
            // 
            this.txtSegundo.Location = new System.Drawing.Point(244, 133);
            this.txtSegundo.Name = "txtSegundo";
            this.txtSegundo.Size = new System.Drawing.Size(100, 20);
            this.txtSegundo.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(244, 200);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(44, 317);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 32);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(227, 316);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(116, 32);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Calcule";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(140, 369);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(104, 41);
            this.btnOut.TabIndex = 8;
            this.btnOut.Text = "Sair";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 525);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSegundo);
            this.Controls.Add(this.txtPrimeiro);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblPrimeiro);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiro;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtPrimeiro;
        private System.Windows.Forms.TextBox txtSegundo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnOut;
    }
}

