using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM.Controls
{
    public class NumericButton : Button
    {

        public string Letters { get; set; }

        public NumericButton() : base()
        {
            FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.DrawString(Letters, new Font(Font.FontFamily, Font.Size / 2), new SolidBrush(ForeColor), new Point(Padding.Left, Padding.Top));
        }

    }
}
