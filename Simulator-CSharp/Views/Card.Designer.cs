namespace ATM.Views
{
    partial class Card
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelBank = new System.Windows.Forms.Label();
            this.pictureBoxCirrus = new System.Windows.Forms.PictureBox();
            this.pictureBoxMaestro = new System.Windows.Forms.PictureBox();
            this.pictureBoxChip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCirrus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChip)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(12, 63);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(185, 17);
            this.labelNumber.TabIndex = 8;
            this.labelNumber.Text = "000000 0000 0000 0000";
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.Location = new System.Drawing.Point(191, 88);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(36, 13);
            this.labelExp.TabIndex = 9;
            this.labelExp.Text = "00/00";
            // 
            // labelBank
            // 
            this.labelBank.AutoSize = true;
            this.labelBank.Location = new System.Drawing.Point(9, 18);
            this.labelBank.Name = "labelBank";
            this.labelBank.Size = new System.Drawing.Size(95, 13);
            this.labelBank.TabIndex = 10;
            this.labelBank.Text = "Entidad Financiera";
            // 
            // pictureBoxCirrus
            // 
            this.pictureBoxCirrus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCirrus.Image = global::ATM.Properties.Resources.Cirrus0;
            this.pictureBoxCirrus.Location = new System.Drawing.Point(194, 34);
            this.pictureBoxCirrus.Name = "pictureBoxCirrus";
            this.pictureBoxCirrus.Size = new System.Drawing.Size(30, 21);
            this.pictureBoxCirrus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCirrus.TabIndex = 6;
            this.pictureBoxCirrus.TabStop = false;
            // 
            // pictureBoxMaestro
            // 
            this.pictureBoxMaestro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaestro.Image = global::ATM.Properties.Resources.Maestro0;
            this.pictureBoxMaestro.Location = new System.Drawing.Point(194, 9);
            this.pictureBoxMaestro.Name = "pictureBoxMaestro";
            this.pictureBoxMaestro.Size = new System.Drawing.Size(30, 21);
            this.pictureBoxMaestro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaestro.TabIndex = 7;
            this.pictureBoxMaestro.TabStop = false;
            // 
            // pictureBoxChip
            // 
            this.pictureBoxChip.Image = global::ATM.Properties.Resources.Chip;
            this.pictureBoxChip.Location = new System.Drawing.Point(12, 34);
            this.pictureBoxChip.Name = "pictureBoxChip";
            this.pictureBoxChip.Size = new System.Drawing.Size(32, 26);
            this.pictureBoxChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChip.TabIndex = 5;
            this.pictureBoxChip.TabStop = false;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelExp);
            this.Controls.Add(this.labelBank);
            this.Controls.Add(this.pictureBoxCirrus);
            this.Controls.Add(this.pictureBoxMaestro);
            this.Controls.Add(this.pictureBoxChip);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(238, 113);
            this.MinimumSize = new System.Drawing.Size(238, 113);
            this.Name = "Card";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.Size = new System.Drawing.Size(236, 111);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Card_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCirrus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label labelNumber;
        internal System.Windows.Forms.Label labelExp;
        internal System.Windows.Forms.Label labelBank;
        internal System.Windows.Forms.PictureBox pictureBoxCirrus;
        internal System.Windows.Forms.PictureBox pictureBoxMaestro;
        internal System.Windows.Forms.PictureBox pictureBoxChip;
    }
}
