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

        public LedenForm()
        {
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

        private void LedenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
