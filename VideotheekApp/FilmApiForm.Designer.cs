namespace VideotheekApp
{
    partial class FilmApiForm
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
            this.tbZoekWaarde = new System.Windows.Forms.TextBox();
            this.lblZoekWaarde = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbMovies = new System.Windows.Forms.ListBox();
            this.lblDoubleClickMovie = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbZoekWaarde
            // 
            this.tbZoekWaarde.Location = new System.Drawing.Point(89, 12);
            this.tbZoekWaarde.Name = "tbZoekWaarde";
            this.tbZoekWaarde.Size = new System.Drawing.Size(146, 23);
            this.tbZoekWaarde.TabIndex = 0;
            // 
            // lblZoekWaarde
            // 
            this.lblZoekWaarde.AutoSize = true;
            this.lblZoekWaarde.Location = new System.Drawing.Point(12, 15);
            this.lblZoekWaarde.Name = "lblZoekWaarde";
            this.lblZoekWaarde.Size = new System.Drawing.Size(71, 15);
            this.lblZoekWaarde.TabIndex = 1;
            this.lblZoekWaarde.Text = "Zoekwaarde";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(241, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Zoeken";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbMovies
            // 
            this.lbMovies.FormattingEnabled = true;
            this.lbMovies.ItemHeight = 15;
            this.lbMovies.Location = new System.Drawing.Point(12, 70);
            this.lbMovies.Name = "lbMovies";
            this.lbMovies.Size = new System.Drawing.Size(304, 409);
            this.lbMovies.TabIndex = 3;
            this.lbMovies.DoubleClick += new System.EventHandler(this.lbMovies_DoubleClick);
            // 
            // lblDoubleClickMovie
            // 
            this.lblDoubleClickMovie.AutoSize = true;
            this.lblDoubleClickMovie.Location = new System.Drawing.Point(12, 43);
            this.lblDoubleClickMovie.Name = "lblDoubleClickMovie";
            this.lblDoubleClickMovie.Size = new System.Drawing.Size(199, 15);
            this.lblDoubleClickMovie.TabIndex = 4;
            this.lblDoubleClickMovie.Text = "Dubbelklik om een film te selecteren";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 485);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FilmApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 513);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDoubleClickMovie);
            this.Controls.Add(this.lbMovies);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblZoekWaarde);
            this.Controls.Add(this.tbZoekWaarde);
            this.Name = "FilmApiForm";
            this.Text = "FilmApiForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbZoekWaarde;
        private Label lblZoekWaarde;
        private Button btnSearch;
        private ListBox lbMovies;
        private Label lblDoubleClickMovie;
        private Button btnCancel;
    }
}