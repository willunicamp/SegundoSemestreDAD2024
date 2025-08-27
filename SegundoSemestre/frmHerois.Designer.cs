namespace SegundoSemestre
{
    partial class frmHerois
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
            this.components = new System.ComponentModel.Container();
            this.imgHeroi = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.cmbRaca = new System.Windows.Forms.ComboBox();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.lstHerois = new System.Windows.Forms.ListBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblHerois = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.numNivel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeroi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // imgHeroi
            // 
            this.imgHeroi.Image = global::SegundoSemestre.Properties.Resources.clerigo;
            this.imgHeroi.InitialImage = null;
            this.imgHeroi.Location = new System.Drawing.Point(12, 12);
            this.imgHeroi.Name = "imgHeroi";
            this.imgHeroi.Size = new System.Drawing.Size(300, 400);
            this.imgHeroi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHeroi.TabIndex = 0;
            this.imgHeroi.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(318, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(285, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(318, 139);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(285, 278);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.Text = "";
            // 
            // cmbRaca
            // 
            this.cmbRaca.FormattingEnabled = true;
            this.cmbRaca.Location = new System.Drawing.Point(374, 86);
            this.cmbRaca.Name = "cmbRaca";
            this.cmbRaca.Size = new System.Drawing.Size(117, 21);
            this.cmbRaca.TabIndex = 4;
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Location = new System.Drawing.Point(497, 86);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(106, 21);
            this.cmbClasse.TabIndex = 5;
            // 
            // lstHerois
            // 
            this.lstHerois.FormattingEnabled = true;
            this.lstHerois.Location = new System.Drawing.Point(609, 23);
            this.lstHerois.Name = "lstHerois";
            this.lstHerois.Size = new System.Drawing.Size(307, 394);
            this.lstHerois.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(318, 7);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(318, 69);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(33, 13);
            this.lblNivel.TabIndex = 8;
            this.lblNivel.Text = "Nível";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(371, 68);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(33, 13);
            this.lblRaca.TabIndex = 9;
            this.lblRaca.Text = "Raça";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(494, 68);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(38, 13);
            this.lblClasse.TabIndex = 10;
            this.lblClasse.Text = "Classe";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(318, 123);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 11;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblHerois
            // 
            this.lblHerois.AutoSize = true;
            this.lblHerois.Location = new System.Drawing.Point(606, 7);
            this.lblHerois.Name = "lblHerois";
            this.lblHerois.Size = new System.Drawing.Size(37, 13);
            this.lblHerois.TabIndex = 12;
            this.lblHerois.Text = "Heróis";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(841, 423);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 39);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Location = new System.Drawing.Point(760, 423);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 39);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // numNivel
            // 
            this.numNivel.Location = new System.Drawing.Point(318, 87);
            this.numNivel.Name = "numNivel";
            this.numNivel.Size = new System.Drawing.Size(50, 20);
            this.numNivel.TabIndex = 16;
            // 
            // frmHerois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 501);
            this.Controls.Add(this.numNivel);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblHerois);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lstHerois);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.cmbRaca);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.imgHeroi);
            this.Name = "frmHerois";
            this.Text = "frmHerois";
            this.Load += new System.EventHandler(this.frmHerois_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHeroi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgHeroi;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.ComboBox cmbRaca;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.ListBox lstHerois;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblHerois;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.NumericUpDown numNivel;
    }
}