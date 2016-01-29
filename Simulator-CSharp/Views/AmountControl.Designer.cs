namespace ATM.Views
{
    partial class AmountControl
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
            this.labelAmount = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.trackBarAmount = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(77, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(52, 13);
            this.labelAmount.TabIndex = 9;
            this.labelAmount.Text = "&Cantidad:";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownAmount.Location = new System.Drawing.Point(80, 17);
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownAmount.TabIndex = 10;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDownAmount_ValueChanged);
            // 
            // trackBarAmount
            // 
            this.trackBarAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarAmount.AutoSize = false;
            this.trackBarAmount.Location = new System.Drawing.Point(0, 17);
            this.trackBarAmount.Maximum = 100;
            this.trackBarAmount.Name = "trackBarAmount";
            this.trackBarAmount.Size = new System.Drawing.Size(74, 20);
            this.trackBarAmount.TabIndex = 8;
            this.trackBarAmount.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarAmount.Scroll += new System.EventHandler(this.trackBarAmount_Scroll);
            // 
            // AmountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.trackBarAmount);
            this.Name = "AmountControl";
            this.Size = new System.Drawing.Size(128, 37);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label labelAmount;
        internal System.Windows.Forms.NumericUpDown numericUpDownAmount;
        internal System.Windows.Forms.TrackBar trackBarAmount;
    }
}
