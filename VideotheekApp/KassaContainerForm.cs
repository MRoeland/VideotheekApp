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
    public partial class KassaContainerForm : Form
    {
        private static KassaContainerForm singeltonForm;

        public KassaContainerForm()
        {
            InitializeComponent();
        }

        public static KassaContainerForm getInstance()
        {
            if (singeltonForm == null || singeltonForm.IsDisposed)
            {
                singeltonForm = new KassaContainerForm();
            }

            return singeltonForm;
        }

        private void KassaContainerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
