using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATM.Controls
{
    public class Button : System.Windows.Forms.Button
    {

        public Button() : base()
        {
            BackColor = System.Drawing.Color.Silver;
            FlatAppearance.BorderSize = 0;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Font = new System.Drawing.Font(Font.FontFamily, 16, Font.Style);
            TabStop = false;
            UseVisualStyleBackColor = false;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Button
            // 
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TabStop = false;
            this.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);

        }
    }
}
