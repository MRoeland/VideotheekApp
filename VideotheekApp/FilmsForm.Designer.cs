namespace VideotheekApp
{
    partial class FilmsForm
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
            this.filmListView = new System.Windows.Forms.ListView();
            this.filmTabControl = new System.Windows.Forms.TabControl();
            this.tabPageDetails = new System.Windows.Forms.TabPage();
            this.pbFilmPoster = new System.Windows.Forms.PictureBox();
            this.gbVerhuur = new System.Windows.Forms.GroupBox();
            this.cbAdults = new System.Windows.Forms.CheckBox();
            this.tbPrijs = new System.Windows.Forms.TextBox();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.tbFilmActeurs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilmRegiseur = new System.Windows.Forms.TextBox();
            this.lblRegiseur = new System.Windows.Forms.Label();
            this.tbFilmTitle = new System.Windows.Forms.TextBox();
            this.tbFilmId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.TabPageReview = new System.Windows.Forms.TabPage();
            this.lblReview = new System.Windows.Forms.Label();
            this.tbReview = new System.Windows.Forms.TextBox();
            this.btnNewMovie = new System.Windows.Forms.Button();
            this.btnEditMovie = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnAddMovieOnline = new System.Windows.Forms.Button();
            this.filmTabControl.SuspendLayout();
            this.tabPageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmPoster)).BeginInit();
            this.gbVerhuur.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.TabPageReview.SuspendLayout();
            this.SuspendLayout();
            // 
            // filmListView
            // 
            this.filmListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filmListView.FullRowSelect = true;
            this.filmListView.Location = new System.Drawing.Point(12, 12);
            this.filmListView.MultiSelect = false;
            this.filmListView.Name = "filmListView";
            this.filmListView.Size = new System.Drawing.Size(1180, 224);
            this.filmListView.TabIndex = 1;
            this.filmListView.UseCompatibleStateImageBehavior = false;
            this.filmListView.View = System.Windows.Forms.View.Details;
            this.filmListView.SelectedIndexChanged += new System.EventHandler(this.filmListView_SelectedIndexChanged);
            // 
            // filmTabControl
            // 
            this.filmTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filmTabControl.Controls.Add(this.tabPageDetails);
            this.filmTabControl.Controls.Add(this.TabPageReview);
            this.filmTabControl.Location = new System.Drawing.Point(12, 271);
            this.filmTabControl.Name = "filmTabControl";
            this.filmTabControl.SelectedIndex = 0;
            this.filmTabControl.Size = new System.Drawing.Size(1180, 360);
            this.filmTabControl.TabIndex = 2;
            // 
            // tabPageDetails
            // 
            this.tabPageDetails.Controls.Add(this.pbFilmPoster);
            this.tabPageDetails.Controls.Add(this.gbVerhuur);
            this.tabPageDetails.Controls.Add(this.gbDetails);
            this.tabPageDetails.Location = new System.Drawing.Point(4, 24);
            this.tabPageDetails.Name = "tabPageDetails";
            this.tabPageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetails.Size = new System.Drawing.Size(1172, 332);
            this.tabPageDetails.TabIndex = 0;
            this.tabPageDetails.Text = "Film";
            this.tabPageDetails.UseVisualStyleBackColor = true;
            // 
            // pbFilmPoster
            // 
            this.pbFilmPoster.Location = new System.Drawing.Point(6, 6);
            this.pbFilmPoster.Name = "pbFilmPoster";
            this.pbFilmPoster.Size = new System.Drawing.Size(252, 320);
            this.pbFilmPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFilmPoster.TabIndex = 3;
            this.pbFilmPoster.TabStop = false;
            // 
            // gbVerhuur
            // 
            this.gbVerhuur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbVerhuur.Controls.Add(this.cbAdults);
            this.gbVerhuur.Controls.Add(this.tbPrijs);
            this.gbVerhuur.Controls.Add(this.lblPrijs);
            this.gbVerhuur.Location = new System.Drawing.Point(972, 0);
            this.gbVerhuur.Name = "gbVerhuur";
            this.gbVerhuur.Size = new System.Drawing.Size(194, 326);
            this.gbVerhuur.TabIndex = 2;
            this.gbVerhuur.TabStop = false;
            this.gbVerhuur.Text = "Verhuur details";
            // 
            // cbAdults
            // 
            this.cbAdults.AutoSize = true;
            this.cbAdults.Location = new System.Drawing.Point(15, 151);
            this.cbAdults.Name = "cbAdults";
            this.cbAdults.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbAdults.Size = new System.Drawing.Size(129, 19);
            this.cbAdults.TabIndex = 14;
            this.cbAdults.Text = "Alleen volwassenen";
            this.cbAdults.UseVisualStyleBackColor = true;
            // 
            // tbPrijs
            // 
            this.tbPrijs.Location = new System.Drawing.Point(68, 34);
            this.tbPrijs.Name = "tbPrijs";
            this.tbPrijs.Size = new System.Drawing.Size(100, 23);
            this.tbPrijs.TabIndex = 12;
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(15, 37);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(29, 15);
            this.lblPrijs.TabIndex = 10;
            this.lblPrijs.Text = "Prijs";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.tbGenre);
            this.gbDetails.Controls.Add(this.lblGenre);
            this.gbDetails.Controls.Add(this.tbFilmActeurs);
            this.gbDetails.Controls.Add(this.label1);
            this.gbDetails.Controls.Add(this.tbFilmRegiseur);
            this.gbDetails.Controls.Add(this.lblRegiseur);
            this.gbDetails.Controls.Add(this.tbFilmTitle);
            this.gbDetails.Controls.Add(this.tbFilmId);
            this.gbDetails.Controls.Add(this.lblId);
            this.gbDetails.Controls.Add(this.lblTitle);
            this.gbDetails.Location = new System.Drawing.Point(264, 0);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(702, 329);
            this.gbDetails.TabIndex = 1;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Film details";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(354, 152);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(153, 23);
            this.tbGenre.TabIndex = 11;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(301, 155);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(38, 15);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.Text = "Genre";
            // 
            // tbFilmActeurs
            // 
            this.tbFilmActeurs.Location = new System.Drawing.Point(354, 34);
            this.tbFilmActeurs.Name = "tbFilmActeurs";
            this.tbFilmActeurs.Size = new System.Drawing.Size(216, 23);
            this.tbFilmActeurs.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Acteurs";
            // 
            // tbFilmRegiseur
            // 
            this.tbFilmRegiseur.Location = new System.Drawing.Point(76, 262);
            this.tbFilmRegiseur.Name = "tbFilmRegiseur";
            this.tbFilmRegiseur.Size = new System.Drawing.Size(160, 23);
            this.tbFilmRegiseur.TabIndex = 6;
            // 
            // lblRegiseur
            // 
            this.lblRegiseur.AutoSize = true;
            this.lblRegiseur.Location = new System.Drawing.Point(18, 262);
            this.lblRegiseur.Name = "lblRegiseur";
            this.lblRegiseur.Size = new System.Drawing.Size(52, 15);
            this.lblRegiseur.TabIndex = 5;
            this.lblRegiseur.Text = "Regiseur";
            // 
            // tbFilmTitle
            // 
            this.tbFilmTitle.Location = new System.Drawing.Point(53, 152);
            this.tbFilmTitle.Name = "tbFilmTitle";
            this.tbFilmTitle.Size = new System.Drawing.Size(183, 23);
            this.tbFilmTitle.TabIndex = 4;
            // 
            // tbFilmId
            // 
            this.tbFilmId.Location = new System.Drawing.Point(53, 34);
            this.tbFilmId.Name = "tbFilmId";
            this.tbFilmId.Size = new System.Drawing.Size(59, 23);
            this.tbFilmId.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(18, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(18, 155);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(29, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // TabPageReview
            // 
            this.TabPageReview.Controls.Add(this.lblReview);
            this.TabPageReview.Controls.Add(this.tbReview);
            this.TabPageReview.Location = new System.Drawing.Point(4, 24);
            this.TabPageReview.Name = "TabPageReview";
            this.TabPageReview.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageReview.Size = new System.Drawing.Size(1172, 332);
            this.TabPageReview.TabIndex = 1;
            this.TabPageReview.Text = "Review";
            this.TabPageReview.UseVisualStyleBackColor = true;
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Location = new System.Drawing.Point(16, 17);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(44, 15);
            this.lblReview.TabIndex = 1;
            this.lblReview.Text = "Review";
            // 
            // tbReview
            // 
            this.tbReview.Location = new System.Drawing.Point(6, 47);
            this.tbReview.Multiline = true;
            this.tbReview.Name = "tbReview";
            this.tbReview.Size = new System.Drawing.Size(1160, 233);
            this.tbReview.TabIndex = 0;
            // 
            // btnNewMovie
            // 
            this.btnNewMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewMovie.Location = new System.Drawing.Point(12, 242);
            this.btnNewMovie.Name = "btnNewMovie";
            this.btnNewMovie.Size = new System.Drawing.Size(75, 23);
            this.btnNewMovie.TabIndex = 3;
            this.btnNewMovie.Text = "New";
            this.btnNewMovie.UseVisualStyleBackColor = true;
            this.btnNewMovie.Click += new System.EventHandler(this.btnNewMovie_Click);
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditMovie.Location = new System.Drawing.Point(12, 637);
            this.btnEditMovie.Name = "btnEditMovie";
            this.btnEditMovie.Size = new System.Drawing.Size(75, 23);
            this.btnEditMovie.TabIndex = 4;
            this.btnEditMovie.Text = "Edit";
            this.btnEditMovie.UseVisualStyleBackColor = true;
            this.btnEditMovie.Click += new System.EventHandler(this.btnEditMovie_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(1117, 637);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1023, 637);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(93, 637);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorMessage.Location = new System.Drawing.Point(12, 663);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(1180, 23);
            this.lblErrorMessage.TabIndex = 8;
            // 
            // btnAddMovieOnline
            // 
            this.btnAddMovieOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddMovieOnline.Location = new System.Drawing.Point(93, 242);
            this.btnAddMovieOnline.Name = "btnAddMovieOnline";
            this.btnAddMovieOnline.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovieOnline.TabIndex = 9;
            this.btnAddMovieOnline.Text = "New online";
            this.btnAddMovieOnline.UseVisualStyleBackColor = true;
            this.btnAddMovieOnline.Click += new System.EventHandler(this.btnAddMovieOnline_Click);
            // 
            // FilmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1204, 695);
            this.Controls.Add(this.btnAddMovieOnline);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEditMovie);
            this.Controls.Add(this.btnNewMovie);
            this.Controls.Add(this.filmTabControl);
            this.Controls.Add(this.filmListView);
            this.Name = "FilmsForm";
            this.Load += new System.EventHandler(this.FilmsForm_Load);
            this.filmTabControl.ResumeLayout(false);
            this.tabPageDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmPoster)).EndInit();
            this.gbVerhuur.ResumeLayout(false);
            this.gbVerhuur.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.TabPageReview.ResumeLayout(false);
            this.TabPageReview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView filmListView;
        private TabControl filmTabControl;
        private TabPage tabPageDetails;
        private TabPage TabPageReview;
        private Button btnNewMovie;
        private Button btnEditMovie;
        private Button btnUpdate;
        private GroupBox gbVerhuur;
        private GroupBox gbDetails;
        private TextBox tbFilmId;
        private Label lblId;
        private Label lblTitle;
        private Label lblRegiseur;
        private TextBox tbFilmTitle;
        private Label label1;
        private TextBox tbFilmRegiseur;
        private TextBox tbPrijs;
        private TextBox tbGenre;
        private Label lblPrijs;
        private Label lblGenre;
        private TextBox tbFilmActeurs;
        private CheckBox cbAdults;
        private Label lblReview;
        private TextBox tbReview;
        private Button btnCancel;
        private Button btnDelete;
        private Label lblErrorMessage;
        private Button btnAddMovieOnline;
        private PictureBox pbFilmPoster;
    }
}