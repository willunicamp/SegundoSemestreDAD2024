namespace SegundoSemestre
{
    partial class frmTermo
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
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.lstFeedback = new System.Windows.Forms.ListBox();
            this.lblTentativas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(12, 12);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(188, 42);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar Palavras";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(125, 83);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 52);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtPalavra
            // 
            this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra.Location = new System.Drawing.Point(12, 106);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(107, 29);
            this.txtPalavra.TabIndex = 2;
            // 
            // lstFeedback
            // 
            this.lstFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFeedback.FormattingEnabled = true;
            this.lstFeedback.ItemHeight = 24;
            this.lstFeedback.Location = new System.Drawing.Point(12, 141);
            this.lstFeedback.Name = "lstFeedback";
            this.lstFeedback.Size = new System.Drawing.Size(188, 172);
            this.lstFeedback.TabIndex = 3;
            // 
            // lblTentativas
            // 
            this.lblTentativas.AutoSize = true;
            this.lblTentativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentativas.Location = new System.Drawing.Point(12, 83);
            this.lblTentativas.Name = "lblTentativas";
            this.lblTentativas.Size = new System.Drawing.Size(82, 20);
            this.lblTentativas.TabIndex = 4;
            this.lblTentativas.Text = "Tentativas";
            // 
            // frmTermo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 325);
            this.Controls.Add(this.lblTentativas);
            this.Controls.Add(this.lstFeedback);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCarregar);
            this.Name = "frmTermo";
            this.Text = "Termo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.ListBox lstFeedback;
        private System.Windows.Forms.Label lblTentativas;
    }
}