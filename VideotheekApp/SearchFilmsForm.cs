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
    public partial class SearchFilmsForm : Form
    {
        public Film SelectedFilm;
        private static SearchFilmsForm SingletonInstance;

        // Using a user defined event to pass the filmId selected to the kassaform
        public delegate void SendMessage(object obj, EventArgs e, String filmIdToPass);
        public event SendMessage OnSendMessage;

        public SearchFilmsForm()
        {
            OnSendMessage = null;
            SelectedFilm = new Film();
            InitializeComponent();
        }
        public static SearchFilmsForm getInstance()
        {
            if (SingletonInstance == null || SingletonInstance.IsDisposed)
            {
                SingletonInstance = new SearchFilmsForm();
            }

            return SingletonInstance;
        }

        private void SearchFilmsForm_Load(object sender, EventArgs e)
        {
            lvFilms.Columns.Insert(0, "Titel", 150);
            lvFilms.Columns.Insert(1, "Regiseur", 100);
            lvFilms.Columns.Insert(2, "Genre", 150);
            lvFilms.Columns.Insert(3, "Adult Rating", 50);

            FillListWithMovies();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if(OnSendMessage != null)
            {
                OnSendMessage(sender, e, SelectedFilm.Id.ToString());
            }
        }

        public void FillListWithMovies()
        {
            string adult = "";
            Repository repo = Repository.GetInstance();
            lvFilms.Items.Clear();
            for (int i = 0; i < repo.Films.Count; i++)
            {
                ListViewItem item = new ListViewItem(repo.Films[i].Title);
                item.SubItems.Add(repo.Films[i].Regiseur);
                item.SubItems.Add(repo.Films[i].Genre);
                if (repo.Films[i].AdultRating == true)
                {
                    adult = "Ja"; 
                }
                else
                {
                    adult = "Neen";
                }
                item.SubItems.Add(adult);
                // Hang film object vast aan list item
                item.Tag = repo.Films[i];
                lvFilms.Items.Add(item);
            }
        }

        private void lvFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFilms.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem selectedItem = lvFilms.SelectedItems[0];
            SelectedFilm = (Film)selectedItem.Tag;
        }

        private void btnResetList_Click(object sender, EventArgs e)
        {
            FillListWithMovies();
            tbSearchFilm.Clear();
        }

        private void btnSearchFilm_Click(object sender, EventArgs e)
        {
            string zoekString = tbSearchFilm.Text.ToLower();
            Film f = null;

            for(int i = lvFilms.Items.Count-1; i >= 0; i--)
            {
                f = (Film)lvFilms.Items[i].Tag;
                if (!f.Title.ToLower().Contains(zoekString) && !f.Regiseur.ToLower().Contains(zoekString))
                {
                    lvFilms.Items.RemoveAt(i);
                }
            }
        }
    }
}
