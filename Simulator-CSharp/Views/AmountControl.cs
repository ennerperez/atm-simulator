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
    public partial class AmountControl : UserControl
    {
        public AmountControl()
        {
            InitializeComponent();
        }

        private int _Value = 0;
        public int Value
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

        #region Events

        private void OnMinimumChanged(EventArgs e)
        {
            numericUpDownAmount.Minimum = this.Minimum;
            trackBarAmount.Minimum = this.Minimum;
        }

        private void OnMaximumChanged(EventArgs e)
        {
            numericUpDownAmount.Maximum = this.Maximum;
            trackBarAmount.Maximum = this.Maximum;
        }

        private void OnValueChanged(EventArgs e)
        {
            numericUpDownAmount.Value = this.Value;
            trackBarAmount.Value = this.Value;
            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }

        public event EventHandler ValueChanged;

        #endregion

        public double Percent()
        {
            return Value * 100 / Maximum;
        }

        private void trackBarAmount_Scroll(object sender, EventArgs e)
        {
            Value = ((TrackBar)sender).Value;
            numericUpDownAmount.Value = Value;
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            Value = (int)((NumericUpDown)sender).Value;
            trackBarAmount.Value = Value;
        }
    }
}
