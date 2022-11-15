namespace VideotheekApp
{
    partial class LedenForm
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
            this.btnAddMember = new System.Windows.Forms.Button();
            this.lvLeden = new System.Windows.Forms.ListView();
            this.gbUitleningen = new System.Windows.Forms.GroupBox();
            this.lvUitleningen = new System.Windows.Forms.ListView();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNr = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNr = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbUitleningen.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddMember.Location = new System.Drawing.Point(12, 145);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(94, 23);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Text = "Toevoegen lid";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // lvLeden
            // 
            this.lvLeden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLeden.FullRowSelect = true;
            this.lvLeden.Location = new System.Drawing.Point(12, 12);
            this.lvLeden.MultiSelect = false;
            this.lvLeden.Name = "lvLeden";
            this.lvLeden.Size = new System.Drawing.Size(776, 127);
            this.lvLeden.TabIndex = 1;
            this.lvLeden.UseCompatibleStateImageBehavior = false;
            this.lvLeden.View = System.Windows.Forms.View.Details;
            this.lvLeden.SelectedIndexChanged += new System.EventHandler(this.lvLeden_SelectedIndexChanged);
            // 
            // gbUitleningen
            // 
            this.gbUitleningen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUitleningen.BackColor = System.Drawing.Color.White;
            this.gbUitleningen.Controls.Add(this.lvUitleningen);
            this.gbUitleningen.Location = new System.Drawing.Point(313, 174);
            this.gbUitleningen.Name = "gbUitleningen";
            this.gbUitleningen.Size = new System.Drawing.Size(475, 249);
            this.gbUitleningen.TabIndex = 7;
            this.gbUitleningen.TabStop = false;
            this.gbUitleningen.Text = "Uitleningen";
            // 
            // lvUitleningen
            // 
            this.lvUitleningen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvUitleningen.FullRowSelect = true;
            this.lvUitleningen.Location = new System.Drawing.Point(6, 22);
            this.lvUitleningen.MultiSelect = false;
            this.lvUitleningen.Name = "lvUitleningen";
            this.lvUitleningen.Size = new System.Drawing.Size(463, 221);
            this.lvUitleningen.TabIndex = 0;
            this.lvUitleningen.UseCompatibleStateImageBehavior = false;
            this.lvUitleningen.View = System.Windows.Forms.View.Details;
            // 
            // gbDetails
            // 
            this.gbDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetails.BackColor = System.Drawing.Color.White;
            this.gbDetails.Controls.Add(this.tbId);
            this.gbDetails.Controls.Add(this.lblId);
            this.gbDetails.Controls.Add(this.tbEmail);
            this.gbDetails.Controls.Add(this.tbNr);
            this.gbDetails.Controls.Add(this.lblEmail);
            this.gbDetails.Controls.Add(this.lblNr);
            this.gbDetails.Controls.Add(this.tbAdres);
            this.gbDetails.Controls.Add(this.lblAdres);
            this.gbDetails.Controls.Add(this.lblName);
            this.gbDetails.Controls.Add(this.tbName);
            this.gbDetails.Location = new System.Drawing.Point(12, 174);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(284, 249);
            this.gbDetails.TabIndex = 6;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(51, 28);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(227, 23);
            this.tbId.TabIndex = 13;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(51, 208);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(227, 23);
            this.tbEmail.TabIndex = 11;
            // 
            // tbNr
            // 
            this.tbNr.Location = new System.Drawing.Point(51, 166);
            this.tbNr.Name = "tbNr";
            this.tbNr.Size = new System.Drawing.Size(227, 23);
            this.tbNr.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 211);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.Location = new System.Drawing.Point(6, 169);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(35, 15);
            this.lblNr.TabIndex = 8;
            this.lblNr.Text = "Tel nr";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(51, 117);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(227, 23);
            this.tbAdres.TabIndex = 7;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(6, 120);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(37, 15);
            this.lblAdres.TabIndex = 6;
            this.lblAdres.Text = "Adres";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Naam";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(51, 73);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(227, 23);
            this.tbName.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(713, 429);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(632, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(12, 429);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(93, 429);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Verwijderen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // LedenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbUitleningen);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.lvLeden);
            this.Controls.Add(this.btnAddMember);
            this.Name = "LedenForm";
            this.Text = "Leden";
            this.Load += new System.EventHandler(this.LedenForm_Load);
            this.gbUitleningen.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddMember;
        private ListView lvLeden;
        private GroupBox gbUitleningen;
        private GroupBox gbDetails;
        private TextBox tbEmail;
        private TextBox tbNr;
        private Label lblEmail;
        private Label lblNr;
        private TextBox tbAdres;
        private Label lblAdres;
        private Label lblName;
        private TextBox tbName;
        private Button btnUpdate;
        private Button btnCancel;
        private Button btnEdit;
        private Button btnDelete;
        private ListView lvUitleningen;
        private TextBox tbId;
        private Label lblId;
    }
}