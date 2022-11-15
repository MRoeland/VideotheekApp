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
    public partial class SearchLedenForm : Form
    {
        private static SearchLedenForm SingletonInstance;
        public Lid SelectedLid;
        public delegate void SendMessage(object obj, EventArgs e, String lidIdToPass);
        public event SendMessage OnSendMessage;

        public SearchLedenForm()
        {
            SelectedLid = null;
            InitializeComponent();
        }
        public static SearchLedenForm getInstance()
        {
            if (SingletonInstance == null || SingletonInstance.IsDisposed)
            {
                SingletonInstance = new SearchLedenForm();
            }

            return SingletonInstance;
        }

        private void SearchLedenForm_Load(object sender, EventArgs e)
        {
            lvMembers.Columns.Insert(0, "Naam", 150);
            lvMembers.Columns.Insert(1, "Adres", 150);
            lvMembers.Columns.Insert(2, "Tel nr", 100);
            lvMembers.Columns.Insert(3, "Email", 150);

            FillListWithLeden();
        }

        private void lvMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMembers.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem selectedItem = lvMembers.SelectedItems[0];
            SelectedLid = (Lid)selectedItem.Tag;
        }

        private void btnSearchMembers_Click(object sender, EventArgs e)
        {
            string zoekString = tbSearchName.Text.ToLower();
            Lid l = null;

            for (int i = lvMembers.Items.Count - 1; i >= 0; i--)
            {
                l = (Lid)lvMembers.Items[i].Tag;
                if (!l.Naam.ToLower().Contains(zoekString) && !l.Email.ToLower().Contains(zoekString))
                {
                    lvMembers.Items.RemoveAt(i);
                }
            }
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            tbSearchName.Clear();
            FillListWithLeden();
        }
        private void btnChooseMemeber_Click(object sender, EventArgs e)
        {
            if (OnSendMessage != null)
            {
                OnSendMessage(sender, e, SelectedLid.Id.ToString());
            }
        }

        public void FillListWithLeden()
        {
            Repository repo = Repository.GetInstance();
            lvMembers.Items.Clear();
            for (int i = 0; i < repo.Leden.Count; i++)
            {
                ListViewItem item = new ListViewItem(repo.Leden[i].Naam);
                item.SubItems.Add(repo.Leden[i].Adres);
                item.SubItems.Add(repo.Leden[i].Telnr);
                item.SubItems.Add(repo.Leden[i].Email);
                // Hang lid object vast aan list item
                item.Tag = repo.Leden[i];
                lvMembers.Items.Add(item);
            }
        }
    }
}
