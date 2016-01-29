namespace ATM.Components
{
    partial class Printer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Printer));
            this.timerDiscart = new System.Windows.Forms.Timer(this.components);
            this.timerPrinting = new System.Windows.Forms.Timer(this.components);
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelReader = new System.Windows.Forms.Panel();
            this.panelPaper = new System.Windows.Forms.Panel();
            this.labelPaper = new System.Windows.Forms.Label();
            this.panelPaper.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerDiscart
            // 
            this.timerDiscart.Interval = 3000;
            this.timerDiscart.Tick += new System.EventHandler(this.timerDiscart_Tick);
            // 
            // timerPrinting
            // 
            this.timerPrinting.Interval = 3000;
            this.timerPrinting.Tick += new System.EventHandler(this.timerPrinting_Tick);
            // 
            // panelStatus
            // 
            this.panelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStatus.BackColor = System.Drawing.Color.LimeGreen;
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Location = new System.Drawing.Point(86, 13);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(64, 8);
            this.panelStatus.TabIndex = 1;
            // 
            // panelReader
            // 
            this.panelReader.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelReader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReader.Location = new System.Drawing.Point(0, 0);
            this.panelReader.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panelReader.Name = "panelReader";
            this.panelReader.Size = new System.Drawing.Size(150, 16);
            this.panelReader.TabIndex = 2;
            // 
            // panelPaper
            // 
            this.panelPaper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPaper.BackColor = System.Drawing.Color.White;
            this.panelPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPaper.Controls.Add(this.labelPaper);
            this.panelPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelPaper.Location = new System.Drawing.Point(2, 3);
            this.panelPaper.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panelPaper.Name = "panelPaper";
            this.panelPaper.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelPaper.Size = new System.Drawing.Size(146, 29);
            this.panelPaper.TabIndex = 5;
            this.panelPaper.Visible = false;
            this.panelPaper.Click += new System.EventHandler(this.panelPaper_Click);
            // 
            // labelPaper
            // 
            this.labelPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPaper.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaper.Location = new System.Drawing.Point(3, 0);
            this.labelPaper.Name = "labelPaper";
            this.labelPaper.Size = new System.Drawing.Size(138, 24);
            this.labelPaper.TabIndex = 0;
            this.labelPaper.Text = resources.GetString("labelPaper.Text");
            // 
            // Printer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPaper);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelReader);
            this.Name = "Printer";
            this.Size = new System.Drawing.Size(150, 34);
            this.EnabledChanged += new System.EventHandler(this._EnabledChanged);
            this.panelPaper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerDiscart;
        private System.Windows.Forms.Timer timerPrinting;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelReader;
        internal System.Windows.Forms.Panel panelPaper;
        internal System.Windows.Forms.Label labelPaper;
    }
}
