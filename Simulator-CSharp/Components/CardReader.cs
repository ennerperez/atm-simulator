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
    public partial class CardReader : UserControl
    {
        public CardReader()
        {
            InitializeComponent();
        }

        private string number;
        public string Number { get { return number; } private set { } }
                
        public bool IsCardInserted { get { return !String.IsNullOrEmpty(number); } private set { } }

        public event EventHandler CardInserted;
        public void OnCardInserted(object sender, EventArgs e)
        {
            panelCard.Visible = true;
            panelReader.BackColor = SystemColors.ControlDarkDark;
            if (CardInserted != null) CardInserted(this, e);
        }

        public void EjectCard()
        {
            Console.WriteLine("Expulsando tarjeta");
            OnCardEjected(this, EventArgs.Empty);
        }

        public event EventHandler CardEjected;
        public void OnCardEjected(object sender, EventArgs e)
        {
            number = null;
            panelCard.Visible = false;
            panelReader.BackColor = SystemColors.ControlDark;
            if (CardEjected != null) CardEjected(this, e);
        }

        private void CardReader_DragDrop(object sender, DragEventArgs e)
        {
            if (!IsCardInserted)
            {
                number = e.Data.GetData(DataFormats.Text).ToString();
                OnCardInserted(this, EventArgs.Empty);
            }
        }

        private void CardReader_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && !IsCardInserted)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelCard_Click(object sender, EventArgs e)
        {
            OnCardEjected(this, EventArgs.Empty);
        }
    }
}
