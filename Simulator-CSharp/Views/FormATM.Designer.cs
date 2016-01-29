namespace ATM.Views
{
    partial class FormATM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormATM));
            this.multiPanelScreen = new MultiPanel();
            this.PageLoading = new MultiPanelPage();
            this.labelLoading = new System.Windows.Forms.Label();
            this.PageWelcome = new MultiPanelPage();
            this.label1 = new System.Windows.Forms.Label();
            this.keyPad1 = new ATM.Components.KeyPad();
            this.multiPanelScreen.SuspendLayout();
            this.PageLoading.SuspendLayout();
            this.PageWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // multiPanelScreen
            // 
            this.multiPanelScreen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.multiPanelScreen.BackColor = System.Drawing.Color.Black;
            this.multiPanelScreen.Controls.Add(this.PageLoading);
            this.multiPanelScreen.Controls.Add(this.PageWelcome);
            this.multiPanelScreen.Location = new System.Drawing.Point(152, 12);
            this.multiPanelScreen.Name = "multiPanelScreen";
            this.multiPanelScreen.SelectedPage = this.PageWelcome;
            this.multiPanelScreen.Size = new System.Drawing.Size(320, 240);
            this.multiPanelScreen.TabIndex = 0;
            // 
            // PageLoading
            // 
            this.PageLoading.BackColor = System.Drawing.Color.DimGray;
            this.PageLoading.Controls.Add(this.labelLoading);
            this.PageLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageLoading.Location = new System.Drawing.Point(0, 0);
            this.PageLoading.Name = "PageLoading";
            this.PageLoading.Size = new System.Drawing.Size(320, 240);
            this.PageLoading.TabIndex = 0;
            this.PageLoading.Text = "Loading";
            // 
            // labelLoading
            // 
            this.labelLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.White;
            this.labelLoading.Location = new System.Drawing.Point(85, 107);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(150, 26);
            this.labelLoading.TabIndex = 0;
            this.labelLoading.Text = "Iniciando ATM";
            // 
            // PageWelcome
            // 
            this.PageWelcome.BackColor = System.Drawing.Color.Gray;
            this.PageWelcome.Controls.Add(this.label1);
            this.PageWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageWelcome.Location = new System.Drawing.Point(0, 0);
            this.PageWelcome.Name = "PageWelcome";
            this.PageWelcome.Size = new System.Drawing.Size(320, 240);
            this.PageWelcome.TabIndex = 1;
            this.PageWelcome.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido,\r\nPara realizar una operación introduzca su tarjeta.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyPad1
            // 
            this.keyPad1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.keyPad1.Location = new System.Drawing.Point(0, 265);
            this.keyPad1.MinimumSize = new System.Drawing.Size(320, 210);
            this.keyPad1.Name = "keyPad1";
            this.keyPad1.Size = new System.Drawing.Size(624, 210);
            this.keyPad1.TabIndex = 1;
            // 
            // FormATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 475);
            this.Controls.Add(this.keyPad1);
            this.Controls.Add(this.multiPanelScreen);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormATM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.multiPanelScreen.ResumeLayout(false);
            this.PageLoading.ResumeLayout(false);
            this.PageLoading.PerformLayout();
            this.PageWelcome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MultiPanel multiPanelScreen;
        private MultiPanelPage PageLoading;
        private System.Windows.Forms.Label labelLoading;
        private MultiPanelPage PageWelcome;
        private System.Windows.Forms.Label label1;
        private Components.KeyPad keyPad1;
    }
}