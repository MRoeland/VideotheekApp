using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideotheekApp
{
    public partial class LedenForm : Form
    {
        private static LedenForm SingletonInstance;
        private Operatie mOperatie;

        public LedenForm()
        {
            mOperatie = Operatie.Viewing;
            SingletonInstance = null;
            InitializeComponent();
        }

        public static LedenForm getInstance()
        {
            if (SingletonInstance == null || SingletonInstance.IsDisposed)
            {
                SingletonInstance = new LedenForm();
            }

            return SingletonInstance;
        }
        public enum Operatie
        {
            Viewing,
            Editing,
            Creating
        }

        private void LedenForm_Load(object sender, EventArgs e)
        {
            lvLeden.Columns.Insert(0, "Naam", 250);
            lvLeden.Columns.Insert(1, "Adres", 250);
            lvLeden.Columns.Insert(2, "Tel nr", 250);
            lvLeden.Columns.Insert(3, "Email", 250);
            ZetKnoppenVolgensOperatie();
        }

        private void ZetKnoppenVolgensOperatie()
        {
            if (mOperatie == Operatie.Viewing)
            {
                MakeTextBoxesReadOnly(lvLeden.Controls, true);
                MakeTextBoxesReadOnly(lvUitleningen.Controls, true);
                btnEdit.Visible = true;
                btnEdit.Visible = true;
                btnCancel.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = true;
            }
            else if (mOperatie == Operatie.Editing)
            {
                MakeTextBoxesReadOnly(lvLeden.Controls, false);
                MakeTextBoxesReadOnly(lvUitleningen.Controls, false);
                btnEdit.Visible = false;
                btnAddMember.Visible = false;
                btnUpdate.Visible = true;
                btnCancel.Visible = true;
                btnDelete.Visible = false;
            }
            else if (mOperatie == Operatie.Creating)
            {
                MakeTextBoxesReadOnly(lvLeden.Controls, false);
                MakeTextBoxesReadOnly(lvUitleningen.Controls, false);
                btnAddMember.Visible = false;
                btnEdit.Visible = false;
                btnUpdate.Visible = true;
                btnCancel.Visible = true;
                btnDelete.Visible = false;
            }
        }
        private void MakeTextBoxesReadOnly(Control.ControlCollection c, bool readOnly)
        {
            if (c == null)
            {
                return;
            }

            for (int i = 0; i < c.Count; i++)
            {
                Control cItem = c[i];

                if (cItem.GetType() == typeof(TextBox))
                {
                    TextBox t = (TextBox)cItem;
                    t.ReadOnly = readOnly;
                }
                if (cItem.GetType() == typeof(CheckBox))
                {
                    CheckBox b = (CheckBox)cItem;
                    b.Enabled = !readOnly;
                }
                if (cItem.Controls.Count > 0)
                {
                    MakeTextBoxesReadOnly(cItem.Controls, readOnly);
                }
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            mOperatie = Operatie.Creating;
            ZetKnoppenVolgensOperatie();

            tbId.ReadOnly = true;
            tbName.Clear();
            tbAdres.Clear();
            tbEmail.Clear();
            tbNr.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mOperatie = Operatie.Viewing;
            ZetKnoppenVolgensOperatie();
        }

        public void FillMemberDetails(Lid l)
        {
            tbName.Text = l.Naam;
            tbAdres.Text = l.Adres;
            tbNr.Text = l.Telnr;
            tbEmail.Text = l.Email;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            mOperatie= Operatie.Viewing;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ben je zeker dat je dit lid wilt verwijderen?", "Verwijder lid", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {

            }
        }
        public void ShowErrorMessage(String error)
        {
            if (error == "")
            {
                lblErrorMessage.Text = "Ready";
                lblErrorMessage.ForeColor = Color.Black;
            }
            else
            {
                lblErrorMessage.Text = error;
                lblErrorMessage.ForeColor = Color.Red;
            }
        }

        public void FillListView()
        {
            Repository repo = Repository.GetInstance();
            lvLeden.Items.Clear();
            for (int i = 0; i < repo.Films.Count; i++)
            {
                ListViewItem item = new ListViewItem(repo.Leden[i].Naam);
                item.SubItems.Add(repo.Leden[i].Adres);
                item.SubItems.Add(repo.Leden[i].Telnr);
                item.SubItems.Add(repo.Leden[i].Email);
                // Hang film object vast aan list item
                item.Tag = repo.Leden[i];
                lvLeden.Items.Add(item);
            }
        }
    }
}
