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
        public Lid selectedLid;
        private Operatie mOperatie;

        public LedenForm()
        {
            selectedLid = null;
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
            FillListView();
            InitialiseerListView();
            ZetKnoppenVolgensOperatie();
        }

        public void InitialiseerListView()
        {
            lvLeden.Columns.Insert(0, "Naam", 250);
            lvLeden.Columns.Insert(1, "Adres", 250);
            lvLeden.Columns.Insert(2, "Tel nr", 250);
            lvLeden.Columns.Insert(3, "Email", 250);
        }

        private void ZetKnoppenVolgensOperatie()
        {
            if (mOperatie == Operatie.Viewing)
            {
                MakeTextBoxesReadOnly(lvLeden.Controls, true);
                MakeTextBoxesReadOnly(lvUitleningen.Controls, true);
                btnAddMember.Visible = true;
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
            int newLidId = Repository.GetInstance().GetNewLidId();

            tbId.Text = newLidId.ToString();
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
            if(mOperatie == Operatie.Creating)
            {
                Lid newLid = new Lid();

                newLid.Id = int.Parse(tbId.Text);
                newLid.Naam = tbName.Text;
                newLid.Adres = tbAdres.Text;
                newLid.Email = tbEmail.Text;
                newLid.Telnr = tbNr.Text;

                ListViewItem newLidItem = new ListViewItem();
                newLidItem.Text = newLid.Naam;
                newLidItem.SubItems.Add(newLid.Adres);
                newLidItem.SubItems.Add(newLid.Telnr);
                newLidItem.SubItems.Add(newLid.Email);
                newLidItem.Tag = newLid;

                lvLeden.Items.Add(newLidItem);
                newLidItem.Selected = true;
                lvLeden.Select();

                Repository.GetInstance().Leden.Add(newLid);
                Repository.GetInstance().InsertNieuwLidInDatabase(newLid);
            }
            else if(mOperatie == Operatie.Editing)
            {
                selectedLid.Naam = tbName.Text;
                selectedLid.Adres = tbAdres.Text;
                selectedLid.Email = tbEmail.Text;
                selectedLid.Telnr = tbNr.Text;


                ListViewItem mijnLidItem = ZoekListViewItemVoorLid(selectedLid);
                mijnLidItem.SubItems.Clear();
                mijnLidItem.Text = selectedLid.Naam;
                mijnLidItem.SubItems.Add(selectedLid.Adres);
                mijnLidItem.SubItems.Add(selectedLid.Telnr);
                mijnLidItem.SubItems.Add(selectedLid.Email);

                Repository.GetInstance().SlaLidOpInDatabase(selectedLid);
            }

            mOperatie= Operatie.Viewing;
            ZetKnoppenVolgensOperatie();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mOperatie = Operatie.Editing;
            ZetKnoppenVolgensOperatie();
            tbId.ReadOnly = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ben je zeker dat je dit lid wilt verwijderen?", "Verwijder lid", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                Repository.GetInstance().DeleteLidFromDatabase(selectedLid);
                ListViewItem deleteItem = ZoekListViewItemVoorLid(selectedLid);
                lvLeden.Items.Remove(deleteItem);

                tbId.Clear();
                tbName.Clear();
                tbAdres.Clear();
                tbNr.Clear();
                tbEmail.Clear();
            }
        }
        

        public void FillListView()
        {
            Repository repo = Repository.GetInstance();
            lvLeden.Items.Clear();
            for (int i = 0; i < repo.Leden.Count; i++)
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

        private void lvLeden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvLeden.SelectedItems.Count == 0)
            {
                btnEdit.Enabled = false;
                selectedLid = null;
                return;
            }

            ListViewItem selectedLidItem = lvLeden.SelectedItems[0];
            selectedLid = (Lid)selectedLidItem.Tag;

            FillMemberDetails(selectedLid);

            btnEdit.Enabled = true;
        }

        private ListViewItem ZoekListViewItemVoorLid(Lid l)
        {
            foreach (ListViewItem i in lvLeden.Items)
            {
                if (i.Tag == l)
                {
                    return i;
                }
            }

            return null;
        }
    }
}
