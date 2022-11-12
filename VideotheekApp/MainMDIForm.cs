using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VideotheekApp
{
    public partial class MainMDIForm : Form
    {
        public Form CurrentOpenForm;
        public Repository mDataRepo;
        public List<OpenMdiForm> CurrentlyOpenForms;
        public MainMDIForm()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = Path.Combine(sCurrentDirectory, @"..\..\..\FilmDatabase.mdf");
            string sFilePath = Path.GetFullPath(sFile);
            sFilePath = sFilePath.Replace("FilmDatabase.mdf", "");
            AppDomain.CurrentDomain.SetData("DataDirectory", sFilePath);

            mDataRepo = Repository.GetInstance();
            mDataRepo.InitialiseDataFromDB();
            CurrentOpenForm = null;
            CurrentlyOpenForms = new List<OpenMdiForm>();
            InitializeComponent();
        }
        private void MainMDIForm_Load(object sender, EventArgs e)
        {

        }

        private void filmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFormToMDi(true, FilmsForm.getInstance(), 0, 0, 1, 1);
        }

        private void ledenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFormToMDi(true, LedenForm.getInstance(), 0, 0, 1, 1);
        }
        private void uitlenenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KassaForm kf = KassaForm.getInstance();
            SearchFilmsForm sf = SearchFilmsForm.getInstance();
            AddFormToMDi(true, kf, 0, 0, 0.7f, 1);
            AddFormToMDi(false, sf, 0.7f, 0, 0.3f, 1);
            sf.OnSendMessage += kf.NieuweFilmGeselecteerdInSearch;
        }

        public void AddFormToMDi(bool sluitenAndereForms, Form newForm, float relativeStartPosX, float relativeStartPosY, float relativeWidth, float relativeHeight)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if(frm == newForm)
                {
                    return;
                }
            }

            if (sluitenAndereForms == true)
            {
                foreach(Form frm in this.MdiChildren)
                {
                    frm.Close();
                }

                CurrentlyOpenForms.Clear();
            }

            newForm.MdiParent = this;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.ControlBox = false;
            newForm.Show();
            int cw = this.ClientSize.Width;
            int ch = this.ClientSize.Height - menuStrip1.Height;
            newForm.Location = new Point((int)(cw * relativeStartPosX), (int)(ch * relativeStartPosY));
            newForm.Width = (int)(cw * relativeWidth) - 4;
            newForm.Height = (int)(ch * relativeHeight) - 4;


            OpenMdiForm newOpenForm = new OpenMdiForm();
            newOpenForm.f = newForm;
            newOpenForm.relX = relativeStartPosX;
            newOpenForm.relY = relativeStartPosY;
            newOpenForm.relB = relativeWidth;
            newOpenForm.relH = relativeHeight;

            CurrentlyOpenForms.Add(newOpenForm);

        }

        private void MainMDIForm_Resize(object sender, EventArgs e)
        {
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height - menuStrip1.Height;

            for (int i = 0; i < CurrentlyOpenForms.Count; i++)
            {
                OpenMdiForm currentOpen = CurrentlyOpenForms[i];
                currentOpen.f.Location = new Point((int)(width * currentOpen.relX), (int)(height * currentOpen.relY));
                currentOpen.f.Width = (int)(width * currentOpen.relB) - 4;
                currentOpen.f.Height = (int)(height * currentOpen.relH) - 4;
            }
        }

        public void SwitchSearchForms(String deKlasseNaamOmTeVerwijderen, Form nieuweForm)
        {
            for(int i = 0; i < CurrentlyOpenForms.Count; i++)
            {
                if (CurrentlyOpenForms[i].f.GetType().Name == deKlasseNaamOmTeVerwijderen)
                {
                    CurrentlyOpenForms[i].f.Close();
                    CurrentlyOpenForms.RemoveAt(i);
                    break;
                }
            }

            AddFormToMDi(false, nieuweForm, 0.7f, 0, 0.3f, 1);
        }
    }
}
