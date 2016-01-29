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
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        public Card(Models.Card card) : this()
        {
            Bank = card.Bank;
            Number = card.Number;
            Exp = card.Exp;
        }

        #region Properties

        private string _Bank = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        public string Bank
        {
            get { return _Bank; }
            set { _Bank = value; }
        }

        private string _Number = "0000 0000 0000 0000";
        public string Number
        {
            get { return _Number; }
            set { _Number = value; }
        }

        private System.DateTime _Exp = DateTime.Now.Date;
        public System.DateTime Exp
        {
            get { return _Exp; }
            set { _Exp = value; }
        }

        private bool _Cirrus = true;
        public bool Cirrus
        {
            get { return _Cirrus; }
            set { _Cirrus = value; }
        }

        private bool _Maestro = true;
        public bool Maestro
        {
            get { return _Maestro; }
            set { _Maestro = value; }
        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            labelBank.Text = this.Bank;
            labelNumber.Text = this.Number;
            labelExp.Text = this.Exp.ToString("MM/yy");
            pictureBoxCirrus.Visible = this.Cirrus;
            pictureBoxMaestro.Visible = this.Maestro;
        }

        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(Number, DragDropEffects.Copy);
        }
    }
}
