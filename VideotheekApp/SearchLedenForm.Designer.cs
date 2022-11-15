namespace VideotheekApp
{
    partial class SearchLedenForm
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
            this.lvMembers = new System.Windows.Forms.ListView();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchMembers = new System.Windows.Forms.Button();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.btnChooseMemeber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMembers
            // 
            this.lvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMembers.FullRowSelect = true;
            this.lvMembers.Location = new System.Drawing.Point(12, 35);
            this.lvMembers.MultiSelect = false;
            this.lvMembers.Name = "lvMembers";
            this.lvMembers.Size = new System.Drawing.Size(408, 475);
            this.lvMembers.TabIndex = 0;
            this.lvMembers.UseCompatibleStateImageBehavior = false;
            this.lvMembers.View = System.Windows.Forms.View.Details;
            this.lvMembers.SelectedIndexChanged += new System.EventHandler(this.lvMembers_SelectedIndexChanged);
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(12, 9);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(96, 15);
            this.lblSearchName.TabIndex = 1;
            this.lblSearchName.Text = "Zoeken op naam";
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(114, 6);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(144, 23);
            this.tbSearchName.TabIndex = 2;
            // 
            // btnSearchMembers
            // 
            this.btnSearchMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchMembers.Location = new System.Drawing.Point(264, 5);
            this.btnSearchMembers.Name = "btnSearchMembers";
            this.btnSearchMembers.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMembers.TabIndex = 3;
            this.btnSearchMembers.Text = "Zoek";
            this.btnSearchMembers.UseVisualStyleBackColor = true;
            this.btnSearchMembers.Click += new System.EventHandler(this.btnSearchMembers_Click);
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSearch.Location = new System.Drawing.Point(345, 6);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(75, 23);
            this.btnResetSearch.TabIndex = 4;
            this.btnResetSearch.Text = "Reset lijst";
            this.btnResetSearch.UseVisualStyleBackColor = true;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // btnChooseMemeber
            // 
            this.btnChooseMemeber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseMemeber.Location = new System.Drawing.Point(345, 516);
            this.btnChooseMemeber.Name = "btnChooseMemeber";
            this.btnChooseMemeber.Size = new System.Drawing.Size(75, 23);
            this.btnChooseMemeber.TabIndex = 5;
            this.btnChooseMemeber.Text = "Kies lid";
            this.btnChooseMemeber.UseVisualStyleBackColor = true;
            this.btnChooseMemeber.Click += new System.EventHandler(this.btnChooseMemeber_Click);
            // 
            // SearchLedenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(432, 551);
            this.Controls.Add(this.btnChooseMemeber);
            this.Controls.Add(this.btnResetSearch);
            this.Controls.Add(this.btnSearchMembers);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.lvMembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchLedenForm";
            this.Text = "SearchLedenForm";
            this.Load += new System.EventHandler(this.SearchLedenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvMembers;
        private Label lblSearchName;
        private TextBox tbSearchName;
        private Button btnSearchMembers;
        private Button btnResetSearch;
        private Button btnChooseMemeber;
    }
}