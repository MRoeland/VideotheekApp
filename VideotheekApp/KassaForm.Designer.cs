namespace VideotheekApp
{
    partial class KassaForm
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
            this.gbKassaHeader = new System.Windows.Forms.GroupBox();
            this.btnChooseCustomer = new System.Windows.Forms.Button();
            this.gpFIlmLines = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChooseMovies = new System.Windows.Forms.Button();
            this.lvFilmList = new System.Windows.Forms.ListView();
            this.gbTotalPrice = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gbKassaHeader.SuspendLayout();
            this.gpFIlmLines.SuspendLayout();
            this.gbTotalPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKassaHeader
            // 
            this.gbKassaHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbKassaHeader.Controls.Add(this.btnChooseCustomer);
            this.gbKassaHeader.Location = new System.Drawing.Point(12, 12);
            this.gbKassaHeader.Name = "gbKassaHeader";
            this.gbKassaHeader.Size = new System.Drawing.Size(598, 134);
            this.gbKassaHeader.TabIndex = 1;
            this.gbKassaHeader.TabStop = false;
            this.gbKassaHeader.Text = "Kassa ";
            // 
            // btnChooseCustomer
            // 
            this.btnChooseCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseCustomer.Location = new System.Drawing.Point(517, 22);
            this.btnChooseCustomer.Name = "btnChooseCustomer";
            this.btnChooseCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnChooseCustomer.TabIndex = 1;
            this.btnChooseCustomer.Text = "Lid kiezen";
            this.btnChooseCustomer.UseVisualStyleBackColor = true;
            this.btnChooseCustomer.Click += new System.EventHandler(this.btnChooseCustomer_Click);
            // 
            // gpFIlmLines
            // 
            this.gpFIlmLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpFIlmLines.Controls.Add(this.btnRemove);
            this.gpFIlmLines.Controls.Add(this.btnChooseMovies);
            this.gpFIlmLines.Controls.Add(this.lvFilmList);
            this.gpFIlmLines.Location = new System.Drawing.Point(12, 152);
            this.gpFIlmLines.Name = "gpFIlmLines";
            this.gpFIlmLines.Size = new System.Drawing.Size(598, 361);
            this.gpFIlmLines.TabIndex = 2;
            this.gpFIlmLines.TabStop = false;
            this.gpFIlmLines.Text = "Films";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(87, 22);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Verwijder film";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChooseMovies
            // 
            this.btnChooseMovies.Location = new System.Drawing.Point(6, 22);
            this.btnChooseMovies.Name = "btnChooseMovies";
            this.btnChooseMovies.Size = new System.Drawing.Size(75, 23);
            this.btnChooseMovies.TabIndex = 1;
            this.btnChooseMovies.Text = "FIlm kiezen";
            this.btnChooseMovies.UseVisualStyleBackColor = true;
            this.btnChooseMovies.Click += new System.EventHandler(this.btnChooseMovies_Click);
            // 
            // lvFilmList
            // 
            this.lvFilmList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFilmList.FullRowSelect = true;
            this.lvFilmList.Location = new System.Drawing.Point(6, 51);
            this.lvFilmList.MultiSelect = false;
            this.lvFilmList.Name = "lvFilmList";
            this.lvFilmList.Size = new System.Drawing.Size(586, 304);
            this.lvFilmList.TabIndex = 0;
            this.lvFilmList.UseCompatibleStateImageBehavior = false;
            this.lvFilmList.View = System.Windows.Forms.View.Details;
            this.lvFilmList.SelectedIndexChanged += new System.EventHandler(this.lvFilmList_SelectedIndexChanged);
            // 
            // gbTotalPrice
            // 
            this.gbTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTotalPrice.Controls.Add(this.tbPrice);
            this.gbTotalPrice.Controls.Add(this.lblPrice);
            this.gbTotalPrice.Location = new System.Drawing.Point(410, 519);
            this.gbTotalPrice.Name = "gbTotalPrice";
            this.gbTotalPrice.Size = new System.Drawing.Size(200, 100);
            this.gbTotalPrice.TabIndex = 3;
            this.gbTotalPrice.TabStop = false;
            this.gbTotalPrice.Text = "Prijs";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(98, 31);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(96, 23);
            this.tbPrice.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 31);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(86, 15);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Totale eindprijs";
            // 
            // KassaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(622, 655);
            this.Controls.Add(this.gbTotalPrice);
            this.Controls.Add(this.gpFIlmLines);
            this.Controls.Add(this.gbKassaHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KassaForm";
            this.Load += new System.EventHandler(this.KassaForm_Load);
            this.gbKassaHeader.ResumeLayout(false);
            this.gpFIlmLines.ResumeLayout(false);
            this.gbTotalPrice.ResumeLayout(false);
            this.gbTotalPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbKassaHeader;
        private Button btnChooseCustomer;
        private GroupBox gpFIlmLines;
        private ListView lvFilmList;
        private GroupBox gbTotalPrice;
        private Button btnChooseMovies;
        private TextBox tbPrice;
        private Label lblPrice;
        private Button btnRemove;
    }
}