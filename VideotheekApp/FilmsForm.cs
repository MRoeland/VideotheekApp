using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            if(f.Poster != "" && f.Poster != null)
            {
                pbFilmPoster.Load(f.Poster);
            }
            else
            {
                Assembly myAssembly = Assembly.GetExecutingAssembly();
                Stream myStream = myAssembly.GetManifestResourceStream("VideotheekApp.images.NoMovieAvailable.png");
                Bitmap bmp = new Bitmap(myStream);

                pbFilmPoster.Image = bmp;

            }
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
                selectedFilm.Poster = pbFilmPoster.ImageLocation;

                ListViewItem mijnFilmItem = ZoekListViewItemVoorFilm(selectedFilm);
                mijnFilmItem.SubItems.Clear();
                mijnFilmItem.Text = selectedFilm.Title;
                mijnFilmItem.SubItems.Add(selectedFilm.Regiseur);
                mijnFilmItem.SubItems.Add(selectedFilm.Genre);

                String errorMessage = Repository.GetInstance().SlaFilmOpInDatabase(selectedFilm);

                ShowErrorMessage(errorMessage);
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
                newFilm.Poster = pbFilmPoster.ImageLocation;

                ListViewItem mijnFilmItem = new ListViewItem();
                mijnFilmItem.Text = newFilm.Title;
                mijnFilmItem.SubItems.Add(newFilm.Regiseur);
                mijnFilmItem.SubItems.Add(newFilm.Genre);
                mijnFilmItem.Tag = newFilm;

                filmListView.Items.Add(mijnFilmItem);
                mijnFilmItem.Selected = true;
                filmListView.Select();

                Repository.GetInstance().Films.Add(newFilm);
                String errorMessage = Repository.GetInstance().InsertNieuweFilmInDatabase(newFilm);

                ShowErrorMessage(errorMessage);
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
                btnDelete.Visible = true;
                btnAddMovieOnline.Visible = true;
            }
            else if(mOperatie == Operatie.Editing)
            {
                MakeTextBoxesReadOnly(tabPageDetails.Controls, false);
                MakeTextBoxesReadOnly(TabPageReview.Controls, false);
                btnEditMovie.Visible = false;
                btnNewMovie.Visible = false;
                btnUpdate.Visible = true;
                btnCancel.Visible = true;
                btnDelete.Visible = false;
                btnAddMovieOnline.Visible = false;
            }
            else if(mOperatie == Operatie.Creating)
            {
                MakeTextBoxesReadOnly(tabPageDetails.Controls, false);
                MakeTextBoxesReadOnly(TabPageReview.Controls, false);
                btnNewMovie.Visible = false;
                btnEditMovie.Visible = false;
                btnUpdate.Visible = true;
                btnCancel.Visible = true;
                btnDelete.Visible = false;
                btnAddMovieOnline.Visible = false;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ben je zeker dat je deze film wilt verwijderen?","Verwijder film", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                String errorMessage = Repository.GetInstance().DeleteFilmFromDatabase(selectedFilm);
                ListViewItem deleteItem = ZoekListViewItemVoorFilm(selectedFilm);
                filmListView.Items.Remove(deleteItem);

                tbFilmId.Clear();
                tbFilmTitle.Clear();
                tbFilmRegiseur.Clear();
                tbFilmActeurs.Clear();
                tbGenre.Clear();
                tbPrijs.Clear();
                tbReview.Clear();
                cbAdults.Checked = false;

                ShowErrorMessage(errorMessage);
            }
        }

        public enum Operatie
        {
            Viewing,
            Editing,
            Creating
        }

        public void ShowErrorMessage(String error)
        {
            if(error == "")
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

        private void btnAddMovieOnline_Click(object sender, EventArgs e)
        {
            FilmApiForm addMovieForm = new FilmApiForm();
            addMovieForm.StartPosition = FormStartPosition.CenterScreen;
            addMovieForm.ShowDialog();
            FilmApiSearchResult newFilm = addMovieForm.selectedFilm;
            Film nieuweFilm = new Film(newFilm);

            mOperatie = Operatie.Creating;
            ZetKnoppenVolgensOperatie();

            int newFilmId = Repository.GetInstance().GetNewFilmId();

            FillFilmDataInDetails(nieuweFilm);

            tbFilmId.Text = newFilmId.ToString();
        }
    }
}
