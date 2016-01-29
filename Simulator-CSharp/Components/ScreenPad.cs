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
    public partial class ScreenPad : UserControl
    {
        public ScreenPad()
        {
            InitializeComponent();
        }

        private int actionPressed;
        public int ActionPressed
        {
            get { return actionPressed; }
        }

        public event EventHandler Pressed;
       
        private void buttonAction_Click(object sender, EventArgs e)
        {
            actionPressed = Convert.ToInt32(((Control)sender).Tag);
            if (Pressed != null)
                Pressed(this, EventArgs.Empty);
        }

    }
}
