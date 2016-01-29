using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM.Views
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        private void PictureBoxCC_Click(object sender, EventArgs e)
        {
            Process.Start("http://creativecommons.org/licenses/by-nc-sa/4.0/");
        }

        private void CurrencyBox_ValueChanged(object sender, EventArgs e)
        {
            LabelAvailablePreview.Text = String.Format("{0:C}", GroupBoxCurrencyBoxes.Controls.OfType<CurrencyBox>().Sum((c) => c.Total));
        }
    }
}
