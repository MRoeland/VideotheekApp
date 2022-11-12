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
        public SearchLedenForm()
        {
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

        }

        private void lvMembers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
