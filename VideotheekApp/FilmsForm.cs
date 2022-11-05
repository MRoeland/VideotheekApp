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
    public partial class FilmsForm : Form
    {
        private static FilmsForm SingletonInstance;
        private Film selectedFilm;
        private Operatie mOperatie;

        public FilmsForm()
        {
            mOperatie = Operatie.Viewing;
            selectedFilm = null;
            SingletonInstance = null;
            InitializeComponent();
        }

        public static FilmsForm getInstance()
        {
            if(SingletonInstance == null || SingletonInstance.IsDisposed)
            {
                SingletonInstance = new FilmsForm();
            }

            return SingletonInstance;
        }

        private void FilmsForm_Load(object sender, EventArgs e)
        {
            InitialiseerListView();
            FillListView();
            ZetKnoppenVolgensOperatie();
        }

        public void InitialiseerListView()
        {
            filmListView.View = View.Details;
            filmListView.Columns.Insert(0, "Titel", 250);
            filmListView.Columns.Insert(1, "Regiseur", 200);
            filmListView.Columns.Insert(2, "Genre", 150);
        }

        public void FillListView()
        {
            Repository repo = Repository.GetInstance();
            filmListView.Items.Clear();
            for (int i = 0;i < repo.Films.Count; i++)
            {
                ListViewItem item = new ListViewItem(repo.Films[i].Title);
                item.SubItems.Add(repo.Films[i].Regiseur);
                item.SubItems.Add(repo.Films[i].Genre);
                // Hang film object vast aan list item
                item.Tag = repo.Films[i];
                filmListView.Items.Add(item);
            }
        }

        private void filmListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(filmListView.SelectedItems.Count == 0)
            {
                btnEditMovie.Enabled = false;
                selectedFilm = null;
                return;
            }

            ListViewItem selectedItem = filmListView.SelectedItems[0];
            selectedFilm = (Film)selectedItem.Tag;

            FillFilmDataInDetails(selectedFilm);
            
            btnEditMovie.Enabled = true;
        }

        private void FillFilmDataInDetails(Film f)
        {
            tbFilmId.Text = f.Id.ToString();
            tbFilmTitle.Text = f.Title;
            tbFilmRegiseur.Text = f.Regiseur;
            tbFilmActeurs.Text = f.Acteurs;
            tbGenre.Text = f.Genre;
            tbPrijs.Text = f.Prijs.ToString();
            cbAdults.Checked = f.AdultRating;
            tbReview.Text = f.Review;
        }

        private void MakeTextBoxesReadOnly(Control.ControlCollection c, bool readOnly)
        {
            if(c == null)
            {
                return;
            }

            for(int i = 0; i < c.Count; i++)
            {
                Control cItem = c[i];

                if (cItem.GetType() == typeof(TextBox))
                {
                    TextBox t = (TextBox)cItem;
                    t.ReadOnly = readOnly;
                }
                if(cItem.GetType() == typeof(CheckBox))
                {
                    CheckBox b = (CheckBox)cItem;
                    b.Enabled = !readOnly;
                }
                if(cItem.Controls.Count > 0)
                {
                    MakeTextBoxesReadOnly(cItem.Controls,readOnly);
                }
            }
        }

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            mOperatie = Operatie.Editing;

            ZetKnoppenVolgensOperatie();

            tbFilmId.ReadOnly = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mOperatie = Operatie.Viewing;
            
            ZetKnoppenVolgensOperatie();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(mOperatie == Operatie.Editing)
            {
                selectedFilm.Title = tbFilmTitle.Text;
                selectedFilm.Regiseur = tbFilmRegiseur.Text;
                selectedFilm.Acteurs = tbFilmActeurs.Text;
                selectedFilm.Genre = tbGenre.Text;
                selectedFilm.Prijs = float.Parse(tbPrijs.Text);
                selectedFilm.Review = tbReview.Text;
                selectedFilm.AdultRating = cbAdults.Checked;

                ListViewItem mijnFilmItem = ZoekListViewItemVoorFilm(selectedFilm);
                mijnFilmItem.SubItems.Clear();
                mijnFilmItem.Text = selectedFilm.Title;
                mijnFilmItem.SubItems.Add(selectedFilm.Regiseur);
                mijnFilmItem.SubItems.Add(selectedFilm.Genre);

                Repository.GetInstance().SlaFilmOpInDatabase(selectedFilm);
            }
            else if(mOperatie == Operatie.Creating)
            {
                Film newFilm = new Film();
                newFilm.Id = int.Parse(tbFilmId.Text);
                newFilm.Title = tbFilmTitle.Text;
                newFilm.Regiseur = tbFilmRegiseur.Text;
                newFilm.Acteurs = tbFilmActeurs.Text;
                newFilm.Genre = tbGenre.Text;
                newFilm.Prijs = float.Parse(tbPrijs.Text);
                newFilm.Review = tbReview.Text;
                newFilm.AdultRating = cbAdults.Checked;

                ListViewItem mijnFilmItem = new ListViewItem();
                mijnFilmItem.Text = newFilm.Title;
                mijnFilmItem.SubItems.Add(newFilm.Regiseur);
                mijnFilmItem.SubItems.Add(newFilm.Genre);
                mijnFilmItem.Tag = newFilm;

                filmListView.Items.Add(mijnFilmItem);
                mijnFilmItem.Selected = true;
                filmListView.Select();

                Repository.GetInstance().Films.Add(newFilm);
                Repository.GetInstance().InsertNieuweFilmInDatabase(newFilm);
            }

            mOperatie = Operatie.Viewing;

            ZetKnoppenVolgensOperatie();
        }

        private void ZetKnoppenVolgensOperatie()
        {
            if(mOperatie == Operatie.Viewing)
            {
                MakeTextBoxesReadOnly(tabPageDetails.Controls, true);
                MakeTextBoxesReadOnly(TabPageReview.Controls, true);
                btnEditMovie.Visible = true;
                btnNewMovie.Visible = true;
                btnCancel.Visible = false;
                btnUpdate.Visible = false;
            }
            else if(mOperatie == Operatie.Editing)
            {
                MakeTextBoxesReadOnly(tabPageDetails.Controls, false);
                MakeTextBoxesReadOnly(TabPageReview.Controls, false);
                btnEditMovie.Visible = false;
                btnNewMovie.Visible = false;
                btnUpdate.Visible = true;
                btnCancel.Visible = true;
            }
            else if(mOperatie == Operatie.Creating)
            {
                MakeTextBoxesReadOnly(tabPageDetails.Controls, false);
                MakeTextBoxesReadOnly(TabPageReview.Controls, false);
                btnNewMovie.Visible = false;
                btnEditMovie.Visible = false;
                btnUpdate.Visible = true;
                btnCancel.Visible = true;
            }
        }

        private ListViewItem ZoekListViewItemVoorFilm(Film f)
        {
            foreach(ListViewItem i in filmListView.Items)
            {
                if(i.Tag == f)
                {
                    return i;
                }
            }

            return null;
        }

        private void btnNewMovie_Click(object sender, EventArgs e)
        {
            mOperatie = Operatie.Creating;
            ZetKnoppenVolgensOperatie();
            int newFilmId = Repository.GetInstance().GetNewFilmId();

            tbFilmId.Text = newFilmId.ToString();
            tbFilmId.ReadOnly = true;
            tbFilmTitle.Clear();
            tbFilmRegiseur.Clear();
            tbFilmActeurs.Clear();
            tbGenre.Clear();
            tbPrijs.Clear();
            tbReview.Clear();
            cbAdults.Checked = false;
        }

        public enum Operatie
        {
            Viewing,
            Editing,
            Creating
        }
    }
}
