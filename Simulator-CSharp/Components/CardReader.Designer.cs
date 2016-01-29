namespace ATM.Components
{
    partial class CardReader
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
            this.timerCard = new System.Windows.Forms.Timer(this.components);
            this.panelReader = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.pictureBoxCirrus = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaestro = new System.Windows.Forms.PictureBox();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCirrus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaestro)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCard
            // 
            this.timerCard.Interval = 1000;
            // 
            // panelReader
            // 
            this.panelReader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelReader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReader.Location = new System.Drawing.Point(0, 0);
            this.panelReader.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panelReader.Name = "panelReader";
            this.panelReader.Size = new System.Drawing.Size(192, 16);
            this.panelReader.TabIndex = 0;
            // 
            // panelCard
            // 
            this.panelCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.pictureBoxMaestro);
            this.panelCard.Controls.Add(this.pictureBoxCirrus);
            this.panelCard.Location = new System.Drawing.Point(5, 5);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(182, 24);
            this.panelCard.TabIndex = 0;
            this.panelCard.Visible = false;
            this.panelCard.Click += new System.EventHandler(this.panelCard_Click);
            // 
            // pictureBoxCirrus
            // 
            this.pictureBoxCirrus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCirrus.Image = global::ATM.Properties.Resources.Cirrus90;
            this.pictureBoxCirrus.Location = new System.Drawing.Point(120, -14);
            this.pictureBoxCirrus.Name = "pictureBoxCirrus";
            this.pictureBoxCirrus.Size = new System.Drawing.Size(21, 30);
            this.pictureBoxCirrus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCirrus.TabIndex = 0;
            this.pictureBoxCirrus.TabStop = false;
            // 
            // pictureBoxMaestro
            // 
            this.pictureBoxMaestro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaestro.Image = global::ATM.Properties.Resources.Maestro90;
            this.pictureBoxMaestro.Location = new System.Drawing.Point(147, -14);
            this.pictureBoxMaestro.Name = "pictureBoxMaestro";
            this.pictureBoxMaestro.Size = new System.Drawing.Size(21, 30);
            this.pictureBoxMaestro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaestro.TabIndex = 0;
            this.pictureBoxMaestro.TabStop = false;
            // 
            // CardReader
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.panelReader);
            this.MinimumSize = new System.Drawing.Size(192, 32);
            this.Name = "CardReader";
            this.Size = new System.Drawing.Size(192, 32);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CardReader_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.CardReader_DragEnter);
            this.panelCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCirrus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaestro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerCard;
        private System.Windows.Forms.Panel panelReader;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.PictureBox pictureBoxCirrus;
        private System.Windows.Forms.PictureBox pictureBoxMaestro;
    }
}
