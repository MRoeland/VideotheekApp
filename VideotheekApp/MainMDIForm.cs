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
    public partial class MainMDIForm : Form
    {
        public Form CurrentOpenForm;
        public Repository mDataRepo;
        public MainMDIForm()
        {
            mDataRepo = Repository.GetInstance();
            mDataRepo.InitialiseDataFromDB();
            CurrentOpenForm = null;
            InitializeComponent();
        }
        private void MainMDIForm_Load(object sender, EventArgs e)
        {

        }

        private void filmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchActiveForm(FilmsForm.getInstance());
        }

        private void ledenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchActiveForm(LedenForm.getInstance()); 
        }
        private void uitlenenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchActiveForm(KassaContainerForm.getInstance());
        }

        public void SwitchActiveForm(Form newForm)
        {
            if(newForm == CurrentOpenForm)
            {
                return;
            }

            if (CurrentOpenForm != null)
            {
                CurrentOpenForm.Close();
            }
            
            newForm.MdiParent = this;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.ControlBox = false;
            newForm.Show();
            newForm.WindowState = FormWindowState.Maximized;

            CurrentOpenForm = newForm;
        }


        
    }
}
