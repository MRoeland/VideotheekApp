namespace VideotheekApp
{
    partial class MainMDIForm
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
            this.administratieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verhuurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitlenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratieToolStripMenuItem,
            this.verhuurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administratieToolStripMenuItem
            // 
            this.administratieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmsToolStripMenuItem,
            this.ledenToolStripMenuItem});
            this.administratieToolStripMenuItem.Name = "administratieToolStripMenuItem";
            this.administratieToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.administratieToolStripMenuItem.Text = "Administratie";
            // 
            // filmsToolStripMenuItem
            // 
            this.filmsToolStripMenuItem.Name = "filmsToolStripMenuItem";
            this.filmsToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.filmsToolStripMenuItem.Text = "Films";
            this.filmsToolStripMenuItem.Click += new System.EventHandler(this.filmsToolStripMenuItem_Click);
            // 
            // ledenToolStripMenuItem
            // 
            this.ledenToolStripMenuItem.Name = "ledenToolStripMenuItem";
            this.ledenToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ledenToolStripMenuItem.Text = "Leden";
            this.ledenToolStripMenuItem.Click += new System.EventHandler(this.ledenToolStripMenuItem_Click);
            // 
            // verhuurToolStripMenuItem
            // 
            this.verhuurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uitlenenToolStripMenuItem});
            this.verhuurToolStripMenuItem.Name = "verhuurToolStripMenuItem";
            this.verhuurToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.verhuurToolStripMenuItem.Text = "Verhuur";
            // 
            // uitlenenToolStripMenuItem
            // 
            this.uitlenenToolStripMenuItem.Name = "uitlenenToolStripMenuItem";
            this.uitlenenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uitlenenToolStripMenuItem.Text = "Uitlenen kassa";
            this.uitlenenToolStripMenuItem.Click += new System.EventHandler(this.uitlenenToolStripMenuItem_Click);
            // 
            // MainMDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMDIForm";
            this.Text = "Videotheek";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMDIForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem administratieToolStripMenuItem;
        private ToolStripMenuItem filmsToolStripMenuItem;
        private ToolStripMenuItem ledenToolStripMenuItem;
        private ToolStripMenuItem verhuurToolStripMenuItem;
        private ToolStripMenuItem uitlenenToolStripMenuItem;
    }
}