namespace ATM.Components
{
    partial class KeyPad
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
            this.buttonConfirm = new ATM.Controls.Button();
            this.buttonVoid = new ATM.Controls.Button();
            this.buttonFix = new ATM.Controls.Button();
            this.buttonCancel = new ATM.Controls.Button();
            this.numericButtonDot = new ATM.Controls.NumericButton();
            this.numericButton9 = new ATM.Controls.NumericButton();
            this.numericButton0 = new ATM.Controls.NumericButton();
            this.numericButton6 = new ATM.Controls.NumericButton();
            this.numericButton8 = new ATM.Controls.NumericButton();
            this.numericButton3 = new ATM.Controls.NumericButton();
            this.numericButton00 = new ATM.Controls.NumericButton();
            this.numericButton5 = new ATM.Controls.NumericButton();
            this.numericButton7 = new ATM.Controls.NumericButton();
            this.numericButton2 = new ATM.Controls.NumericButton();
            this.numericButton4 = new ATM.Controls.NumericButton();
            this.numericButton1 = new ATM.Controls.NumericButton();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonConfirm.BackColor = System.Drawing.Color.Silver;
            this.buttonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirm.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonConfirm.ForeColor = System.Drawing.Color.Green;
            this.buttonConfirm.Location = new System.Drawing.Point(192, 162);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Padding = new System.Windows.Forms.Padding(3);
            this.buttonConfirm.Size = new System.Drawing.Size(128, 48);
            this.buttonConfirm.TabIndex = 15;
            this.buttonConfirm.TabStop = false;
            this.buttonConfirm.Text = "CONFIRMAR";
            this.buttonConfirm.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.OnButtonConfirmClick);
            // 
            // buttonVoid
            // 
            this.buttonVoid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonVoid.BackColor = System.Drawing.Color.Silver;
            this.buttonVoid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVoid.Enabled = false;
            this.buttonVoid.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonVoid.Location = new System.Drawing.Point(192, 108);
            this.buttonVoid.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.buttonVoid.Name = "buttonVoid";
            this.buttonVoid.Padding = new System.Windows.Forms.Padding(3);
            this.buttonVoid.Size = new System.Drawing.Size(128, 48);
            this.buttonVoid.TabIndex = 14;
            this.buttonVoid.TabStop = false;
            this.buttonVoid.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonVoid.UseVisualStyleBackColor = false;
            // 
            // buttonFix
            // 
            this.buttonFix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFix.BackColor = System.Drawing.Color.Silver;
            this.buttonFix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFix.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonFix.ForeColor = System.Drawing.Color.Yellow;
            this.buttonFix.Location = new System.Drawing.Point(192, 54);
            this.buttonFix.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Padding = new System.Windows.Forms.Padding(3);
            this.buttonFix.Size = new System.Drawing.Size(128, 48);
            this.buttonFix.TabIndex = 13;
            this.buttonFix.TabStop = false;
            this.buttonFix.Text = "CORREGIR";
            this.buttonFix.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonFix.UseVisualStyleBackColor = false;
            this.buttonFix.Click += new System.EventHandler(this.OnButtonFixClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancel.BackColor = System.Drawing.Color.Silver;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCancel.ForeColor = System.Drawing.Color.Red;
            this.buttonCancel.Location = new System.Drawing.Point(192, 0);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Padding = new System.Windows.Forms.Padding(3);
            this.buttonCancel.Size = new System.Drawing.Size(128, 48);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "CANCELAR";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.OnButtonCancelClick);
            // 
            // numericButtonDot
            // 
            this.numericButtonDot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericButtonDot.BackColor = System.Drawing.Color.Silver;
            this.numericButtonDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericButtonDot.Enabled = false;
            this.numericButtonDot.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.numericButtonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericButtonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.numericButtonDot.Letters = "";
            this.numericButtonDot.Location = new System.Drawing.Point(108, 162);
            this.numericButtonDot.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.numericButtonDot.Name = "numericButtonDot";
            this.numericButtonDot.Padding = new System.Windows.Forms.Padding(3);
            this.numericButtonDot.Size = new System.Drawing.Size(48, 48);
            this.numericButtonDot.TabIndex = 11;
            this.numericButtonDot.TabStop = false;
            this.numericButtonDot.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.numericButtonDot.UseVisualStyleBackColor = false;
            this.numericButtonDot.Click += new System.EventHandler(this._Pressed);
            // 
            // numericButton9
            // 
            this.numericButton9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericButton9.BackColor = System.Drawing.Color.Silver;
            this.numericButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericButton9.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.numericButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.numericButton9.Letters = "WXY";
            this.numericButton9.Location = new System.Drawing.Point(108, 108);
            this.numericButton9.Name = "numericButton9";
            this.numericButton9.Padding = new System.Windows.Forms.Padding(3);
            this.numericButton9.Size = new System.Drawing.Size(48, 48);
            this.numericButton9.TabIndex = 8;
            this.numericButton9.TabStop = false;
            this.numericButton9.Text = "9";
            this.numericButton9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.numericButton9.UseVisualStyleBackColor = false;
            this.numericButton9.Click += new System.EventHandler(this._Pressed);
            // 
            // numericButton0
            // 
            this.numericButton0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericButton0.BackColor = System.Drawing.Color.Silver;
            this.numericButton0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericButton0.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.numericButton0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.numericButton0.Letters = "";
            this.numericButton0.Location = new System.Drawing.Point(54, 162);
            this.numericButton0.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.numericButton0.Name = "numericButton0";
            this.numericButton0.Padding = new System.Windows.Forms.Padding(3);
            this.numericButton0.Size = new System.Drawing.Size(48, 48);
            this.numericButton0.TabIndex = 10;
            this.numericButton0.TabStop = false;
            this.numericButton0.Text = "0";
            this.numericButton0.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.numericButton0.UseVisualStyleBackColor = false;
            this.numericButton0.Click += new System.EventHandler(this._Pressed);
            // 
            // numericButton6
            // 
            this.numericButton6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericButton6.BackColor = System.Drawing.Color.Silver;
            this.numericButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericButton6.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.numericButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.numericButton6.Letters = "MNO";
            this.numericButton6.Location = new System.Drawing.Point(108, 54);
            this.numericButton6.Name = "numericButton6";
            this.numericButton6.Padding = new System.Windows.Forms.Padding(3);
            this.numericButton6.Size = new System.Drawing.Size(48, 48);
            this.numericButton6.TabIndex = 5;
            this.numericButton6.TabStop = false;
            this.numericButton6.Text = "6";
            this.numericButton6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.numericButton6.UseVisualStyleBackColor = false;
            this.numericButton6.Click += new System.EventHandler(this._Pressed);
            // 
            // numericButton8
            // 
            this.numericButton8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericButton8.BackColor = System.Drawing.Color.Silver;
            this.numericButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericButton8.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.numericButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.numericButton8.Letters = "TUV";
            this.numericButton8.Location = new System.Drawing.Point(54, 108);
            this.numericButton8.Name = "numericButton8";
            this.numericButton8.Padding = new System.Windows.Forms.Padding(3);
            this.numericButton8.Size = new System.Drawing.Size(48, 48);
            this.numericButton8.TabIndex = 7;
            this.numericButton8.TabStop = false;
            this.numericButton8.Text = "8";
            this.numericButton8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.numericButton8.UseVisualStyleBackColor = false;
            this.numericButton8.Click += new System.EventHandler(this._Pressed);
            // 
            // numericButton3
            // 
            this.numericButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericButton3.BackColor = System.Drawing.Color.Silver;
            this.numericButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericButton3.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.numericButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.numericButton3.Letters = "DEF";
            this.numericButton3.Location = new System.Drawing.Point(108, 0);
            this.numericButton3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.numericButton3.Name = "numericButton3";
            this.numericButton3.Padding = new System.Windows.Forms.Padding(3);
            this.numericButton3.Size = new System.Drawing.Size(48, 48);
            this.numericButton3.TabIndex = 2;
            this.numericButton3.TabStop = false;
            this.numericButton3.Text = "3";
            this.numericButton3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.numericButton3.UseVisualStyleBackColor = false;
            this.numericButton3.Click += new System.EventHandler(this._Pressed);
            // 
            // numericButton00
            // 
            this.numericButton00.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericButton00.BackColor = System.Drawing.Color.Silver;
            this.numericButton00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericButton00.Enabled = false;
            this.numericButton00.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.numericButton00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericButton00.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.numericButton00.Letters = "";
            this.numericButton00.Location = new System.Drawing.Point(0, 162);
            this.numericButton00.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.numericButton00.Name = "numericButton00";
            this.numericButton00.Padding = new System.Windows.Forms.Padding(3);
            this.numericButton00.Size = new System.Drawing.Size(48, 48);
            this.numericButton00.TabIndex = 9;
            this.numericButton00.TabStop = false;
            this.numericButton00.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.numericButton00.UseVisualStyleBackColor = false;
            this.numericButton00.Click += new System.EventHandler(this._Pressed);
            // 
            // numericButton5
            // 
            this.numericButton5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericButton5.BackColor = System.Drawing.Color.Silver;
            this.numericButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericButton5.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.numericButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.numericButton5.Letters = "JKL";
            this.numericButton5.Location = new System.Drawing.Point(54, 54);
            this.numericButton5.Name = "numericButton5";
            this.numericButton5.Padding = new System.Windows.Forms.Padding(3);
            this.numericButton5.Size = new System.Drawing.Size(48, 48);
            this.numericButton5.TabIndex = 4;
            this.numericButton5.TabStop = false;
            this.numericButton5.Text = "5";
            this.numericButton5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.numericButton5.UseVisualStyleBackColor = false;
            this.numericButton5.Click += new System.EventHandler(this._Pressed);
            // 
            // numericButton7
            // 
            this.numericButton7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericButton7.BackColor = System.Drawing.Color.Silver;
            this.numericButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericButton7.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.numericButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.numericButton7.Letters = "PRS";
            this.numericButton7.Location = new System.Drawing.Point(0, 108);
            this.numericButton7.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.numericButton7.Name = "numericButton7";
            this.numericButton7.Padding = new System.Windows.Forms.Padding(3);
            this.numericButton7.Size = new System.Drawing.Size(48, 48);
            this.numericButton7.TabIndex = 6;
            this.numericButton7.TabStop = false;
            this.numericButton7.Text = "7";
            this.numericButton7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.numericButton7.UseVisualStyleBackColor = false;
            this.numericButton7.Click += new System.EventHandler(this._Pressed);
            // 
            // numericButton2
            // 
            this.numericButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericButton2.BackColor = System.Drawing.Color.Silver;
            this.numericButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.numericButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.numericButton2.Letters = "ABC";
            this.numericButton2.Location = new System.Drawing.Point(54, 0);
            this.numericButton2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.numericButton2.Name = "numericButton2";
            this.numericButton2.Padding = new System.Windows.Forms.Padding(3);
            this.numericButton2.Size = new System.Drawing.Size(48, 48);
            this.numericButton2.TabIndex = 1;
            this.numericButton2.TabStop = false;
            this.numericButton2.Text = "2";
            this.numericButton2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.numericButton2.UseVisualStyleBackColor = false;
            this.numericButton2.Click += new System.EventHandler(this._Pressed);
            // 
            // numericButton4
            // 
            this.numericButton4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericButton4.BackColor = System.Drawing.Color.Silver;
            this.numericButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericButton4.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.numericButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.numericButton4.Letters = "GHI";
            this.numericButton4.Location = new System.Drawing.Point(0, 54);
            this.numericButton4.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.numericButton4.Name = "numericButton4";
            this.numericButton4.Padding = new System.Windows.Forms.Padding(3);
            this.numericButton4.Size = new System.Drawing.Size(48, 48);
            this.numericButton4.TabIndex = 3;
            this.numericButton4.TabStop = false;
            this.numericButton4.Text = "4";
            this.numericButton4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.numericButton4.UseVisualStyleBackColor = false;
            this.numericButton4.Click += new System.EventHandler(this._Pressed);
            // 
            // numericButton1
            // 
            this.numericButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericButton1.BackColor = System.Drawing.Color.Silver;
            this.numericButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.numericButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numericButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.numericButton1.Letters = "QZ";
            this.numericButton1.Location = new System.Drawing.Point(0, 0);
            this.numericButton1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.numericButton1.Name = "numericButton1";
            this.numericButton1.Padding = new System.Windows.Forms.Padding(3);
            this.numericButton1.Size = new System.Drawing.Size(48, 48);
            this.numericButton1.TabIndex = 0;
            this.numericButton1.TabStop = false;
            this.numericButton1.Text = "1";
            this.numericButton1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.numericButton1.UseVisualStyleBackColor = false;
            this.numericButton1.Click += new System.EventHandler(this._Pressed);
            // 
            // KeyPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonVoid);
            this.Controls.Add(this.buttonFix);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.numericButtonDot);
            this.Controls.Add(this.numericButton9);
            this.Controls.Add(this.numericButton0);
            this.Controls.Add(this.numericButton6);
            this.Controls.Add(this.numericButton8);
            this.Controls.Add(this.numericButton3);
            this.Controls.Add(this.numericButton00);
            this.Controls.Add(this.numericButton5);
            this.Controls.Add(this.numericButton7);
            this.Controls.Add(this.numericButton2);
            this.Controls.Add(this.numericButton4);
            this.Controls.Add(this.numericButton1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(320, 210);
            this.Name = "KeyPad";
            this.Size = new System.Drawing.Size(320, 210);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.NumericButton numericButton1;
        private Controls.NumericButton numericButton2;
        private Controls.NumericButton numericButton3;
        private Controls.NumericButton numericButton4;
        private Controls.NumericButton numericButton5;
        private Controls.NumericButton numericButton6;
        private Controls.NumericButton numericButton7;
        private Controls.NumericButton numericButton8;
        private Controls.NumericButton numericButton9;
        private Controls.NumericButton numericButton00;
        private Controls.NumericButton numericButton0;
        private Controls.NumericButton numericButtonDot;
        private Controls.Button buttonCancel;
        private Controls.Button buttonFix;
        private Controls.Button buttonVoid;
        private Controls.Button buttonConfirm;
    }
}
