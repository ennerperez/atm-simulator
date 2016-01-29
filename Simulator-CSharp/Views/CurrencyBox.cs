using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM.Views
{
    public partial class CurrencyBox : UserControl
    {
        public CurrencyBox()
        {
            InitializeComponent();
        }

        #region Properties

        private double _Total = 0.0;
        public double Total
        {
            get { return _Total; }
        }

        private double _Value;
        public double Value
        {
            get { return _Value; }
            set
            {
                if (_Value != value)
                {
                    _Value = value;
                    OnValueChanged(EventArgs.Empty);
                }
            }
        }
        private int _Amount;
        public int Amount
        {
            get { return _Amount; }
            set
            {
                if (_Amount != value)
                {
                    _Amount = value;
                    OnAmountChanged(EventArgs.Empty);
                }
            }
        }

        private int _Minimum = 0;
        public int Minimum
        {
            get { return _Minimum; }
            set
            {
                if (_Minimum != value)
                {
                    _Minimum = value;
                    OnMinimumChanged(EventArgs.Empty);
                }
            }
        }
        private int _Maximum = 100;
        public int Maximum
        {
            get { return _Maximum; }
            set
            {
                if (_Maximum != value)
                {
                    _Maximum = value;
                    OnMaximumChanged(EventArgs.Empty);
                }
            }
        }

        #endregion

        #region Events

        private void OnMinimumChanged(EventArgs e)
        {
            amountControl.Minimum = Minimum;
        }

        private void OnMaximumChanged(EventArgs e)
        {
            amountControl.Maximum = Maximum;
        }

        private void OnAmountChanged(EventArgs e)
        {
            amountControl.Value = Amount;
            CalcTotal();
        }

        private void OnValueChanged(EventArgs e)
        {
            comboBoxDenomination.SelectedItem = Value.ToString();
            CalcTotal();
        }

        private void CalcTotal()
        {
            double _result = 0.0;
            if (comboBoxDenomination.SelectedItem != null && !string.IsNullOrEmpty(comboBoxDenomination.SelectedItem.ToString()))
            {
                _result = Convert.ToDouble(comboBoxDenomination.SelectedItem) * amountControl.Value;
            }

            if (_result != this._Total)
            {
                this._Total = _result;
                if (ValueChanged != null)
                {
                    ValueChanged(this, EventArgs.Empty);
                }
            }

        }

        public event EventHandler ValueChanged;

        #endregion

        private void SubTotal()
        {
            textBoxTotal.Text = string.Format("{0:C}", Total);
            double _percent = Percent();

            if (_percent == 0)
            {
                BackColor = SystemColors.Control;
            }
            else if (_percent > 0 && _percent < 25)
            {
                BackColor = Color.FromArgb(245, 68, 55);
            }
            else if (_percent >= 25 && _percent < 50)
            {
                BackColor = Color.FromArgb(255, 153, 0);
            }
            else {
                BackColor = Color.FromArgb(77, 176, 81);
            }
        }

        public double Percent()
        {
            return amountControl.Percent();
        }

        private void amountControl_ValueChanged(object sender, EventArgs e)
        {
            Amount = amountControl.Value;
            SubTotal();
        }

        private void comboBoxDenomination_SelectedIndexChanged(object sender, EventArgs e)
        {
            Value = Double.Parse(comboBoxDenomination.SelectedItem.ToString());
            SubTotal();
        }
    }
}
