﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideotheekApp
{
    public partial class KassaForm : Form
    {
        private static KassaForm SingletonInstance;
        public Film selectedFilm;
        public float totaalPrijs;

        public KassaForm()
        {
            totaalPrijs = 0;
            selectedFilm = null;
            InitializeComponent();
        }

        private void KassaForm_Load(object sender, EventArgs e)
        {
            lvFilmList.Columns.Insert(0, "Titel", 150);
            lvFilmList.Columns.Insert(1, "Genre", 150);
            lvFilmList.Columns.Insert(2, "Adult Rating", 100);
            lvFilmList.Columns.Insert(3, "Prijs", 50);
            lvFilmList.Columns.Insert(4, "Rated", 50);
        }

        public static KassaForm getInstance()
        {
            if (SingletonInstance == null || SingletonInstance.IsDisposed)
            {
                SingletonInstance = new KassaForm();
            }

            return SingletonInstance;
        }

        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            MainMDIForm myParent = (MainMDIForm)MdiParent;
            myParent.SwitchSearchForms("SearchFilmsForm", SearchLedenForm.getInstance());
        }

        private void btnChooseMovies_Click(object sender, EventArgs e)
        {
            MainMDIForm myParent = (MainMDIForm)MdiParent;
            myParent.SwitchSearchForms("SearchLedenForm", SearchFilmsForm.getInstance());
            SearchFilmsForm.getInstance().OnSendMessage += NieuweFilmGeselecteerdInSearch;
        }

        public void NieuweFilmGeselecteerdInSearch(object obj, EventArgs e, string filmIdToPass)
        {
            foreach(ListViewItem i in lvFilmList.Items)
            {
                Film f = (Film)i.Tag;
                if (f.Id == int.Parse(filmIdToPass))
                {
                    MessageBox.Show("Deze film zit al in je winkelmandje.", "Dubbele film");
                    return;
                }
            }

            float price = 0;
            string adult = "";
            string rated = "";
            Repository repo = Repository.GetInstance();
            for (int i = 0; i < repo.Films.Count; i++)
            {
                if (repo.Films[i].Id == int.Parse(filmIdToPass))
                {
                    ListViewItem item = new ListViewItem(repo.Films[i].Title);
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
                    price = repo.Films[i].Prijs;
                    totaalPrijs += price;
                    item.SubItems.Add(price.ToString());
                    if(repo.Films[i].Rated == "" || repo.Films[i].Rated == null)
                    {
                        rated = "N/A";
                    }
                    else
                    {
                        rated = repo.Films[i].Rated;
                    }
                    item.SubItems.Add(rated);
                    // Hang film object vast aan list item
                    item.Tag = repo.Films[i];
                    lvFilmList.Items.Add(item);

                    tbPrice.Text = "€ " + totaalPrijs.ToString();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ben je zeker dat je deze film uit je winkelmandje wilt verwijderen?", "Verwijder film", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ListViewItem deleteItem = ZoekListViewItemVoorFilm(selectedFilm);
                lvFilmList.Items.Remove(deleteItem);
            }
        }

        private ListViewItem ZoekListViewItemVoorFilm(Film f)
        {
            foreach (ListViewItem i in lvFilmList.Items)
            {
                if (i.Tag == f)
                {
                    return i;
                }
            }

            return null;
        }

        private void lvFilmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFilmList.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem selectedItem = lvFilmList.SelectedItems[0];
            selectedFilm = (Film)selectedItem.Tag;
        }
    }
}