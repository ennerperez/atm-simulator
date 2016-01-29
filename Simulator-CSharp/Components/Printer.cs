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
    public partial class Printer : UserControl
    {
        public Printer()
        {
            InitializeComponent();
        }

        public Models.Receipt Receipt { get; set; }

        public void Print()
        {
            panelStatus.BackColor = Color.Orange;
            timerPrinting.Start();
        }

        public void Discart()
        {
            panelStatus.BackColor = (Enabled ? Color.LimeGreen : Color.Red);
            Receipt = null;
            panelPaper.Visible = false;
        }

        private string SecureIt(string source, char chr = '+', int visible = 4)
        {
            if (source.Length > visible)
            {
                var hiddend = source.Substring(0, source.Length - visible).Length;
                return source.PadRight(hiddend, chr);
            }
            else {
                return source;
            }
        }

        public string Generate(Models.Receipt source)
        {
            string _template = Properties.Resources.Receipt;

            string _result = _template
                .Replace("{BANK}", source.Bank)
                .Replace("{ATM}", source.ATM)
                .Replace("{CODE}", source.Code)
                .Replace("{DATE}", source.Date.ToShortDateString())
                .Replace("{TIME}", source.Date.ToShortTimeString())
                .Replace("{CARD}", SecureIt(source.Card))
                .Replace("{OPERATION}", source.Operation)
                .Replace("{ACCOUNT}", SecureIt(source.Account))
                .Replace("{DETAIL}", source.Detail);

            return _result;
        }

        private void timerDiscart_Tick(object sender, EventArgs e)
        {
            Discart();
            timerDiscart.Stop();
        }

        private void timerPrinting_Tick(object sender, EventArgs e)
        {
            panelPaper.Visible = true;
            timerPrinting.Stop();
            timerDiscart.Start();
        }

        private void panelPaper_Click(object sender, EventArgs e)
        {
            Form _ReceiptPreview = new Form();


            {
                _ReceiptPreview.FormBorderStyle = FormBorderStyle.FixedSingle;
                _ReceiptPreview.StartPosition = FormStartPosition.CenterScreen;
                _ReceiptPreview.Icon = this.FindForm().Icon;
                _ReceiptPreview.Padding = new Padding(3);
                _ReceiptPreview.Size = new Size(240, 320);
                _ReceiptPreview.MaximizeBox = false;

                Panel _receipt = new Panel();
                _receipt.Padding = new Padding(6);
                _receipt.BackColor = Color.White;
                _receipt.Font = new Font("Consolas", 8);
                _receipt.BorderStyle = BorderStyle.FixedSingle;
                _receipt.Dock = DockStyle.Fill;
                _receipt.Controls.Add(new Label
                {
                    Dock = DockStyle.Fill,
                    AutoSize = false,
                    Text = Generate(this.Receipt)
                });

                _ReceiptPreview.Controls.Add(_receipt);

                _ReceiptPreview.Show();

            }
            this.Discart();
        }

        private void _EnabledChanged(object sender, EventArgs e)
        {
            panelStatus.BackColor = (Enabled ? Color.LimeGreen : Color.Red);
        }
    }
}
