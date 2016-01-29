namespace ATM.Views
{
    partial class CurrencyBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxDenomination = new System.Windows.Forms.ComboBox();
            this.labelDenomination = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.amountControl = new ATM.Views.AmountControl();
            this.SuspendLayout();
            // 
            // comboBoxDenomination
            // 
            this.comboBoxDenomination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDenomination.FormattingEnabled = true;
            this.comboBoxDenomination.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "100",
            "500",
            "1000"});
            this.comboBoxDenomination.Location = new System.Drawing.Point(10, 25);
            this.comboBoxDenomination.Name = "comboBoxDenomination";
            this.comboBoxDenomination.Size = new System.Drawing.Size(77, 21);
            this.comboBoxDenomination.TabIndex = 8;
            this.comboBoxDenomination.SelectedIndexChanged += new System.EventHandler(this.comboBoxDenomination_SelectedIndexChanged);
            // 
            // labelDenomination
            // 
            this.labelDenomination.AutoSize = true;
            this.labelDenomination.Location = new System.Drawing.Point(6, 6);
            this.labelDenomination.Name = "labelDenomination";
            this.labelDenomination.Size = new System.Drawing.Size(78, 13);
            this.labelDenomination.TabIndex = 7;
            this.labelDenomination.Text = "&Denominación:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotal.Location = new System.Drawing.Point(230, 25);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 21);
            this.textBoxTotal.TabIndex = 10;
            this.textBoxTotal.Text = "0.000.000.00 BSF";
            this.textBoxTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(296, 6);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "&Total:";
            // 
            // amountControl
            // 
            this.amountControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountControl.Location = new System.Drawing.Point(92, 6);
            this.amountControl.Maximum = 100;
            this.amountControl.Minimum = 0;
            this.amountControl.Name = "amountControl";
            this.amountControl.Size = new System.Drawing.Size(132, 37);
            this.amountControl.TabIndex = 11;
            this.amountControl.Value = 100;
            this.amountControl.ValueChanged += new System.EventHandler(this.amountControl_ValueChanged);
            // 
            // CurrencyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(176)))), ((int)(((byte)(81)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.amountControl);
            this.Controls.Add(this.comboBoxDenomination);
            this.Controls.Add(this.labelDenomination);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Name = "CurrencyBox";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(339, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox comboBoxDenomination;
        internal System.Windows.Forms.Label labelDenomination;
        internal System.Windows.Forms.Label textBoxTotal;
        internal System.Windows.Forms.Label labelTotal;
        private ATM.Views.AmountControl amountControl;
    }
}
