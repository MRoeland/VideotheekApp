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
        public VerhuurLijn selectedLijn;

        public LedenForm()
        {
            selectedLid = null;
            selectedLijn = null;
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

            lvUitleningen.Columns.Insert(0, "Film", 300);
            lvUitleningen.Columns.Insert(1, "Uitleendatum", 200);
            lvUitleningen.Columns.Insert(2, "Terugbreng datum", 200);
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
            tbId.Text = l.Id.ToString();
            tbName.Text = l.Naam;
            tbAdres.Text = l.Adres;
            tbNr.Text = l.Telnr;
            tbEmail.Text = l.Email;

            
        }

        public void FillAllUitleningen(Lid l)
        {
            Repository repo = Repository.GetInstance();
            lvUitleningen.Items.Clear();
            repo.HaalVerhuurAfMetLidId(l);
            for (int i = 0; i < repo.VerhuurLijnenVanLid.Count; i++)
            {
                Film f =repo.HaalFilmVanVerhuurLijn(repo.VerhuurLijnenVanLid[i]);
                if(f == null)
                {
                    continue;
                }
                ListViewItem item = new ListViewItem(f.Title);
                item.SubItems.Add(repo.VerhuurLijnenVanLid[i].UitleenDatum.ToString());
                item.SubItems.Add(repo.VerhuurLijnenVanLid[i].TerugDatum.ToString());

                item.Tag = repo.VerhuurLijnenVanLid[i];
                lvUitleningen.Items.Add(item);
            }
        }

        public void FillUitleningenNotReturned(Lid l)
        {
            Repository repo = Repository.GetInstance();
            lvUitleningen.Items.Clear();
            repo.HaalVerhuurAfMetLidId(l);
            for (int i = 0; i < repo.VerhuurLijnenVanLid.Count; i++)
            {
                if(repo.VerhuurLijnenVanLid[i].TerugDatum == null)
                {
                    Film f = repo.HaalFilmVanVerhuurLijn(repo.VerhuurLijnenVanLid[i]);
                    if(f == null)
                    {
                        continue;
                    }
                    ListViewItem item = new ListViewItem(f.Title);
                    item.SubItems.Add(repo.VerhuurLijnenVanLid[i].UitleenDatum.ToString());
                    item.SubItems.Add(repo.VerhuurLijnenVanLid[i].TerugDatum.ToString());

                    item.Tag = repo.VerhuurLijnenVanLid[i];
                    lvUitleningen.Items.Add(item);
                }
            }
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

        private void cbNotReturned_CheckedChanged(object sender, EventArgs e)
        {
            if(cbNotReturned.Checked == true)
            {
                FillUitleningenNotReturned(selectedLid);
            }
            else if(cbNotReturned.Checked == false)
            {
                FillAllUitleningen(selectedLid);
            }
        }

        private void btnReturnFilm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wil je deze film terugbrengen?", "Terugbrengen film", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                selectedLijn.TerugDatum = DateTime.Now;
                Repository.GetInstance().SlaLijnOpInDatabase(selectedLijn);

                if(cbNotReturned.Checked == true)
                {
                    FillUitleningenNotReturned(selectedLid);
                }
                else if(cbNotReturned.Checked == false)
                {
                    FillAllUitleningen(selectedLid);
                }
            }
        }

        private void lvUitleningen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUitleningen.SelectedItems.Count == 0)
            {
                btnReturnFilm.Visible = false;
                selectedLijn = null;
                return;
            }

            btnReturnFilm.Visible = true;
            ListViewItem selectedLidItem = lvUitleningen.SelectedItems[0];
            selectedLijn = (VerhuurLijn)selectedLidItem.Tag;
        }

        private void lvLeden_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (lvLeden.SelectedItems.Count == 0)
            {
                btnEdit.Enabled = false;
                selectedLid = null;
                return;
            }

            ListViewItem selectedLidItem = lvLeden.SelectedItems[0];
            selectedLid = (Lid)selectedLidItem.Tag;

            FillMemberDetails(selectedLid);
            FillAllUitleningen(selectedLid);

            btnEdit.Enabled = true;
        }
    }
}
