namespace SegundoSemestre
{
    partial class frmRaca
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
            this.lblRaca = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.lstRacas = new System.Windows.Forms.ListBox();
            this.numPV = new System.Windows.Forms.NumericUpDown();
            this.lblPV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(12, 14);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(36, 13);
            this.lblRaca.TabIndex = 5;
            this.lblRaca.Text = "Raça:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSalvar.Location = new System.Drawing.Point(119, 90);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(12, 37);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(182, 20);
            this.txtRaca.TabIndex = 3;
            // 
            // lstRacas
            // 
            this.lstRacas.FormattingEnabled = true;
            this.lstRacas.Location = new System.Drawing.Point(15, 130);
            this.lstRacas.Name = "lstRacas";
            this.lstRacas.Size = new System.Drawing.Size(179, 277);
            this.lstRacas.TabIndex = 6;
            // 
            // numPV
            // 
            this.numPV.Location = new System.Drawing.Point(12, 90);
            this.numPV.Name = "numPV";
            this.numPV.Size = new System.Drawing.Size(91, 20);
            this.numPV.TabIndex = 7;
            // 
            // lblPV
            // 
            this.lblPV.AutoSize = true;
            this.lblPV.Location = new System.Drawing.Point(12, 74);
            this.lblPV.Name = "lblPV";
            this.lblPV.Size = new System.Drawing.Size(75, 13);
            this.lblPV.TabIndex = 8;
            this.lblPV.Text = "P.V. por nível:";
            // 
            // frmRaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 417);
            this.Controls.Add(this.lblPV);
            this.Controls.Add(this.numPV);
            this.Controls.Add(this.lstRacas);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtRaca);
            this.Name = "frmRaca";
            this.Text = "Raças";
            ((System.ComponentModel.ISupportInitialize)(this.numPV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.ListBox lstRacas;
        private System.Windows.Forms.NumericUpDown numPV;
        private System.Windows.Forms.Label lblPV;
    }
}