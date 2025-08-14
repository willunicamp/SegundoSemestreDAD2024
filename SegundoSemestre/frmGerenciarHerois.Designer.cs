namespace SegundoSemestre
{
    partial class frmGerenciarHerois
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemHerois = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRaca = new System.Windows.Forms.ToolStripMenuItem();
            this.itemClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMissoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemHerois,
            this.itemRaca,
            this.itemClasses,
            this.itemMissoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemHerois
            // 
            this.itemHerois.Name = "itemHerois";
            this.itemHerois.Size = new System.Drawing.Size(85, 20);
            this.itemHerois.Text = "&Meus Heróis";
            this.itemHerois.Click += new System.EventHandler(this.itemHerois_Click);
            // 
            // itemRaca
            // 
            this.itemRaca.Name = "itemRaca";
            this.itemRaca.Size = new System.Drawing.Size(49, 20);
            this.itemRaca.Text = "&Raças";
            // 
            // itemClasses
            // 
            this.itemClasses.Name = "itemClasses";
            this.itemClasses.Size = new System.Drawing.Size(57, 20);
            this.itemClasses.Text = "&Classes";
            // 
            // itemMissoes
            // 
            this.itemMissoes.Name = "itemMissoes";
            this.itemMissoes.Size = new System.Drawing.Size(61, 20);
            this.itemMissoes.Text = "&Missões";
            // 
            // frmGerenciarHerois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmGerenciarHerois";
            this.Text = "Meus Heróis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemHerois;
        private System.Windows.Forms.ToolStripMenuItem itemRaca;
        private System.Windows.Forms.ToolStripMenuItem itemClasses;
        private System.Windows.Forms.ToolStripMenuItem itemMissoes;
    }
}