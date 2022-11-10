namespace VideotheekApp
{
    partial class SearchFilmsForm
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
            this.tbSearchFilm = new System.Windows.Forms.TextBox();
            this.lblFilm = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnResetList = new System.Windows.Forms.Button();
            this.btnSearchFilm = new System.Windows.Forms.Button();
            this.lvFilms = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tbSearchFilm
            // 
            this.tbSearchFilm.Location = new System.Drawing.Point(124, 6);
            this.tbSearchFilm.Name = "tbSearchFilm";
            this.tbSearchFilm.Size = new System.Drawing.Size(134, 23);
            this.tbSearchFilm.TabIndex = 2;
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(12, 9);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(106, 15);
            this.lblFilm.TabIndex = 3;
            this.lblFilm.Text = "Zoek voor een film";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMovie.Location = new System.Drawing.Point(194, 592);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(226, 23);
            this.btnAddMovie.TabIndex = 4;
            this.btnAddMovie.Text = "Voeg film toe aan je winkelmandje";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnResetList
            // 
            this.btnResetList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetList.Location = new System.Drawing.Point(345, 6);
            this.btnResetList.Name = "btnResetList";
            this.btnResetList.Size = new System.Drawing.Size(75, 23);
            this.btnResetList.TabIndex = 5;
            this.btnResetList.Text = "Reset lijst";
            this.btnResetList.UseVisualStyleBackColor = true;
            this.btnResetList.Click += new System.EventHandler(this.btnResetList_Click);
            // 
            // btnSearchFilm
            // 
            this.btnSearchFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchFilm.Location = new System.Drawing.Point(264, 6);
            this.btnSearchFilm.Name = "btnSearchFilm";
            this.btnSearchFilm.Size = new System.Drawing.Size(75, 23);
            this.btnSearchFilm.TabIndex = 6;
            this.btnSearchFilm.Text = "Zoek";
            this.btnSearchFilm.UseVisualStyleBackColor = true;
            this.btnSearchFilm.Click += new System.EventHandler(this.btnSearchFilm_Click);
            // 
            // lvFilms
            // 
            this.lvFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFilms.FullRowSelect = true;
            this.lvFilms.Location = new System.Drawing.Point(12, 35);
            this.lvFilms.MultiSelect = false;
            this.lvFilms.Name = "lvFilms";
            this.lvFilms.Size = new System.Drawing.Size(408, 551);
            this.lvFilms.TabIndex = 7;
            this.lvFilms.UseCompatibleStateImageBehavior = false;
            this.lvFilms.View = System.Windows.Forms.View.Details;
            this.lvFilms.SelectedIndexChanged += new System.EventHandler(this.lvFilms_SelectedIndexChanged);
            // 
            // SearchFilmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(432, 627);
            this.Controls.Add(this.lvFilms);
            this.Controls.Add(this.btnSearchFilm);
            this.Controls.Add(this.btnResetList);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.lblFilm);
            this.Controls.Add(this.tbSearchFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchFilmsForm";
            this.Text = "SearchFilmsForm";
            this.Load += new System.EventHandler(this.SearchFilmsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbSearchFilm;
        private Label lblFilm;
        private Button btnAddMovie;
        private Button btnResetList;
        private Button btnSearchFilm;
        private ListView lvFilms;
    }
}