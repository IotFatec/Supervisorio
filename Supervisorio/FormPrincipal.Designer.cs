namespace Supervisorio
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSBHomePage = new System.Windows.Forms.ToolStripButton();
            this.tSBDados = new System.Windows.Forms.ToolStripButton();
            this.tSBAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBHomePage,
            this.tSBDados,
            this.tSBAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(71, 403);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tSBHomePage
            // 
            this.tSBHomePage.AutoSize = false;
            this.tSBHomePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBHomePage.Image = global::Supervisorio.Properties.Resources.Home;
            this.tSBHomePage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSBHomePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBHomePage.Name = "tSBHomePage";
            this.tSBHomePage.Size = new System.Drawing.Size(70, 70);
            this.tSBHomePage.Text = "Principal";
            this.tSBHomePage.Click += new System.EventHandler(this.tSBHomePage_Click);
            // 
            // tSBDados
            // 
            this.tSBDados.AutoSize = false;
            this.tSBDados.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBDados.Image = global::Supervisorio.Properties.Resources.Statistics;
            this.tSBDados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSBDados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBDados.Name = "tSBDados";
            this.tSBDados.Size = new System.Drawing.Size(70, 70);
            this.tSBDados.Text = "Dados";
            this.tSBDados.Click += new System.EventHandler(this.tSBDados_Click);
            // 
            // tSBAbout
            // 
            this.tSBAbout.AutoSize = false;
            this.tSBAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBAbout.Image = global::Supervisorio.Properties.Resources.AboutUs;
            this.tSBAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tSBAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBAbout.Name = "tSBAbout";
            this.tSBAbout.Size = new System.Drawing.Size(70, 70);
            this.tSBAbout.Text = "Sobre nós";
            this.tSBAbout.Click += new System.EventHandler(this.tSBAbout_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 403);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INDUSTRIA INTELIGENTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSBHomePage;
        private System.Windows.Forms.ToolStripButton tSBDados;
        private System.Windows.Forms.ToolStripButton tSBAbout;
    }
}

