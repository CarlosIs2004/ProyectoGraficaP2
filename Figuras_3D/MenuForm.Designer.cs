namespace Figuras_3D
{
    partial class MenuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.poliedrosRegularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliedrosIrregularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poliedrosRegularesToolStripMenuItem,
            this.poliedrosIrregularesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // poliedrosRegularesToolStripMenuItem
            // 
            this.poliedrosRegularesToolStripMenuItem.Name = "poliedrosRegularesToolStripMenuItem";
            this.poliedrosRegularesToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.poliedrosRegularesToolStripMenuItem.Text = "Poliedros Regulares";
            this.poliedrosRegularesToolStripMenuItem.Click += new System.EventHandler(this.poliedrosRegularesToolStripMenuItem_Click);
            // 
            // poliedrosIrregularesToolStripMenuItem
            // 
            this.poliedrosIrregularesToolStripMenuItem.Name = "poliedrosIrregularesToolStripMenuItem";
            this.poliedrosIrregularesToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.poliedrosIrregularesToolStripMenuItem.Text = "Poliedros Irregulares";
            this.poliedrosIrregularesToolStripMenuItem.Click += new System.EventHandler(this.poliedrosIrregularesToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem poliedrosRegularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliedrosIrregularesToolStripMenuItem;
    }
}