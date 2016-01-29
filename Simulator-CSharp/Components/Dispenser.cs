using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM.Components
{
    public partial class Dispenser : UserControl
    {
        public Dispenser()
        {
            InitializeComponent();
        }

        private void _EnabledChanged(object sender, EventArgs e)
        {
            panelStatus.BackColor = (Enabled ? Color.LimeGreen : Color.Red);
        }
    }
}
