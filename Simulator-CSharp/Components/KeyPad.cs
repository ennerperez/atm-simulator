using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ATM.Controls;

namespace ATM.Components
{
    public partial class KeyPad : UserControl
    {
        public KeyPad()
        {
            InitializeComponent();
        }

        public event EventHandler Pressed;

        private void _Pressed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Valor) || Valor.Length < MaxLenght)
            {
                Valor += ((NumericButton)sender).Text;
                if (Pressed != null)
                {
                    Pressed(this, EventArgs.Empty);
                }
            }
        }


        public int MinLenght { get; set; }
        public int MaxLenght { get; set; }

        public string Valor { get; set; }

        #region Events

        public event EventHandler Cancel;
        public event EventHandler Fix;
        public event EventHandler Confirm;
        public event EventHandler Error;

        #endregion

        private void OnButtonCancelClick(object sender, EventArgs e)
        {
            if (Cancel != null)
            {
                Cancel(this, EventArgs.Empty);
            }
        }

        private void OnButtonFixClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Valor) && Valor.Length > 0)
            {
                Valor = Valor.Substring(0, Valor.Length - 1);
            }
            if (Fix != null)
            {
                Fix(this, EventArgs.Empty);
            }
        }

        private void OnButtonConfirmClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Valor) && Valor.Length <= MaxLenght && Valor.Length == MinLenght)
            {
                Confirm(this, EventArgs.Empty);
            }
            else
            {
                Error(this, EventArgs.Empty);
            }
        }

    }
}
