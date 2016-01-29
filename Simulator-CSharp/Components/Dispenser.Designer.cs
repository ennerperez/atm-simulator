namespace ATM.Components
{
    partial class Dispenser
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
            this.panelReader = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelReader
            // 
            this.panelReader.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelReader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReader.Location = new System.Drawing.Point(0, 0);
            this.panelReader.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panelReader.Name = "panelReader";
            this.panelReader.Size = new System.Drawing.Size(380, 16);
            this.panelReader.TabIndex = 0;
            // 
            // panelStatus
            // 
            this.panelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStatus.BackColor = System.Drawing.Color.LimeGreen;
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Location = new System.Drawing.Point(316, 19);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(64, 8);
            this.panelStatus.TabIndex = 0;
            // 
            // Dispenser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelReader);
            this.Name = "Dispenser";
            this.Size = new System.Drawing.Size(380, 30);
            this.EnabledChanged += new System.EventHandler(this._EnabledChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReader;
        private System.Windows.Forms.Panel panelStatus;
    }
}
