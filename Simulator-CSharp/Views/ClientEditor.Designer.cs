namespace ATM.Views
{
    partial class ClientEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonAccept = new System.Windows.Forms.Button();
            this.PanelAction = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.CollumnCardAccount2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CollumnCardAccount1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CollumnCardExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollumnCardPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCards = new System.Windows.Forms.DataGridView();
            this.TabPageCards = new System.Windows.Forms.TabPage();
            this.ColumnAccountBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAccountType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnAccountBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.ColumnAccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPageAccounts = new System.Windows.Forms.TabPage();
            this.TextBoxIdentification = new System.Windows.Forms.TextBox();
            this.TextBoxFullName = new System.Windows.Forms.TextBox();
            this.LabelIdentification = new System.Windows.Forms.Label();
            this.LabelFullName = new System.Windows.Forms.Label();
            this.TabPageGeneral = new System.Windows.Forms.TabPage();
            this.TabControlClient = new System.Windows.Forms.TabControl();
            this.PanelAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCards)).BeginInit();
            this.TabPageCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAccounts)).BeginInit();
            this.TabPageAccounts.SuspendLayout();
            this.TabPageGeneral.SuspendLayout();
            this.TabControlClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAccept
            // 
            this.ButtonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAccept.Location = new System.Drawing.Point(494, 6);
            this.ButtonAccept.Name = "ButtonAccept";
            this.ButtonAccept.Size = new System.Drawing.Size(75, 23);
            this.ButtonAccept.TabIndex = 0;
            this.ButtonAccept.Text = "&Aceptar";
            this.ButtonAccept.UseVisualStyleBackColor = true;
            this.ButtonAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // PanelAction
            // 
            this.PanelAction.Controls.Add(this.ButtonCancel);
            this.PanelAction.Controls.Add(this.ButtonAccept);
            this.PanelAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelAction.Location = new System.Drawing.Point(0, 265);
            this.PanelAction.Name = "PanelAction";
            this.PanelAction.Size = new System.Drawing.Size(573, 32);
            this.PanelAction.TabIndex = 3;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Location = new System.Drawing.Point(413, 6);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "&Cancelar";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // CollumnCardAccount2
            // 
            this.CollumnCardAccount2.DataPropertyName = "Account2";
            this.CollumnCardAccount2.HeaderText = "C. Corriente";
            this.CollumnCardAccount2.Name = "CollumnCardAccount2";
            this.CollumnCardAccount2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CollumnCardAccount2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CollumnCardAccount1
            // 
            this.CollumnCardAccount1.DataPropertyName = "Account1";
            this.CollumnCardAccount1.HeaderText = "C. Ahorro";
            this.CollumnCardAccount1.Name = "CollumnCardAccount1";
            this.CollumnCardAccount1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CollumnCardAccount1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CollumnCardExp
            // 
            this.CollumnCardExp.DataPropertyName = "Exp";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.CollumnCardExp.DefaultCellStyle = dataGridViewCellStyle7;
            this.CollumnCardExp.HeaderText = "Vence";
            this.CollumnCardExp.Name = "CollumnCardExp";
            // 
            // CollumnCardPassword
            // 
            this.CollumnCardPassword.DataPropertyName = "Password";
            this.CollumnCardPassword.HeaderText = "Clave";
            this.CollumnCardPassword.Name = "CollumnCardPassword";
            // 
            // ColumnCardNumber
            // 
            this.ColumnCardNumber.DataPropertyName = "Number";
            this.ColumnCardNumber.HeaderText = "Número";
            this.ColumnCardNumber.Name = "ColumnCardNumber";
            // 
            // ColumnBank
            // 
            this.ColumnBank.DataPropertyName = "Bank";
            this.ColumnBank.HeaderText = "Banco";
            this.ColumnBank.Name = "ColumnBank";
            // 
            // DataGridViewCards
            // 
            this.DataGridViewCards.AllowUserToOrderColumns = true;
            this.DataGridViewCards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewCards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBank,
            this.ColumnCardNumber,
            this.CollumnCardPassword,
            this.CollumnCardExp,
            this.CollumnCardAccount1,
            this.CollumnCardAccount2});
            this.DataGridViewCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewCards.Location = new System.Drawing.Point(9, 9);
            this.DataGridViewCards.Name = "DataGridViewCards";
            this.DataGridViewCards.RowHeadersVisible = false;
            this.DataGridViewCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewCards.Size = new System.Drawing.Size(547, 221);
            this.DataGridViewCards.TabIndex = 2;
            this.DataGridViewCards.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridViewCards_DataError);
            // 
            // TabPageCards
            // 
            this.TabPageCards.Controls.Add(this.DataGridViewCards);
            this.TabPageCards.Location = new System.Drawing.Point(4, 22);
            this.TabPageCards.Name = "TabPageCards";
            this.TabPageCards.Padding = new System.Windows.Forms.Padding(9);
            this.TabPageCards.Size = new System.Drawing.Size(565, 239);
            this.TabPageCards.TabIndex = 2;
            this.TabPageCards.Text = "Tarjetas";
            this.TabPageCards.UseVisualStyleBackColor = true;
            // 
            // ColumnAccountBalance
            // 
            this.ColumnAccountBalance.DataPropertyName = "Balance";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.ColumnAccountBalance.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnAccountBalance.HeaderText = "Balance";
            this.ColumnAccountBalance.Name = "ColumnAccountBalance";
            // 
            // ColumnAccountType
            // 
            this.ColumnAccountType.DataPropertyName = "Type";
            this.ColumnAccountType.HeaderText = "Tipo";
            this.ColumnAccountType.Items.AddRange(new object[] {
            "Ahorro",
            "Corriente"});
            this.ColumnAccountType.Name = "ColumnAccountType";
            this.ColumnAccountType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnAccountBank
            // 
            this.ColumnAccountBank.DataPropertyName = "Bank";
            this.ColumnAccountBank.HeaderText = "Banco";
            this.ColumnAccountBank.Name = "ColumnAccountBank";
            // 
            // DataGridViewAccounts
            // 
            this.DataGridViewAccounts.AllowUserToOrderColumns = true;
            this.DataGridViewAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAccountBank,
            this.ColumnAccountType,
            this.ColumnAccountNumber,
            this.ColumnAccountBalance});
            this.DataGridViewAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewAccounts.Location = new System.Drawing.Point(9, 9);
            this.DataGridViewAccounts.Name = "DataGridViewAccounts";
            this.DataGridViewAccounts.RowHeadersVisible = false;
            this.DataGridViewAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewAccounts.Size = new System.Drawing.Size(547, 221);
            this.DataGridViewAccounts.TabIndex = 1;
            // 
            // ColumnAccountNumber
            // 
            this.ColumnAccountNumber.DataPropertyName = "Number";
            this.ColumnAccountNumber.HeaderText = "Número";
            this.ColumnAccountNumber.Name = "ColumnAccountNumber";
            // 
            // TabPageAccounts
            // 
            this.TabPageAccounts.Controls.Add(this.DataGridViewAccounts);
            this.TabPageAccounts.Location = new System.Drawing.Point(4, 22);
            this.TabPageAccounts.Name = "TabPageAccounts";
            this.TabPageAccounts.Padding = new System.Windows.Forms.Padding(9);
            this.TabPageAccounts.Size = new System.Drawing.Size(565, 239);
            this.TabPageAccounts.TabIndex = 1;
            this.TabPageAccounts.Text = "Cuentas";
            this.TabPageAccounts.UseVisualStyleBackColor = true;
            // 
            // TextBoxIdentification
            // 
            this.TextBoxIdentification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxIdentification.Location = new System.Drawing.Point(12, 64);
            this.TextBoxIdentification.Name = "TextBoxIdentification";
            this.TextBoxIdentification.Size = new System.Drawing.Size(487, 20);
            this.TextBoxIdentification.TabIndex = 1;
            // 
            // TextBoxFullName
            // 
            this.TextBoxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFullName.Location = new System.Drawing.Point(12, 25);
            this.TextBoxFullName.Name = "TextBoxFullName";
            this.TextBoxFullName.Size = new System.Drawing.Size(487, 20);
            this.TextBoxFullName.TabIndex = 1;
            // 
            // LabelIdentification
            // 
            this.LabelIdentification.AutoSize = true;
            this.LabelIdentification.Location = new System.Drawing.Point(12, 48);
            this.LabelIdentification.Name = "LabelIdentification";
            this.LabelIdentification.Size = new System.Drawing.Size(73, 13);
            this.LabelIdentification.TabIndex = 0;
            this.LabelIdentification.Text = "&Identificación:";
            // 
            // LabelFullName
            // 
            this.LabelFullName.AutoSize = true;
            this.LabelFullName.Location = new System.Drawing.Point(12, 9);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.Size = new System.Drawing.Size(93, 13);
            this.LabelFullName.TabIndex = 0;
            this.LabelFullName.Text = "&Nombre completo:";
            // 
            // TabPageGeneral
            // 
            this.TabPageGeneral.Controls.Add(this.TextBoxIdentification);
            this.TabPageGeneral.Controls.Add(this.TextBoxFullName);
            this.TabPageGeneral.Controls.Add(this.LabelIdentification);
            this.TabPageGeneral.Controls.Add(this.LabelFullName);
            this.TabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.TabPageGeneral.Name = "TabPageGeneral";
            this.TabPageGeneral.Padding = new System.Windows.Forms.Padding(9);
            this.TabPageGeneral.Size = new System.Drawing.Size(565, 239);
            this.TabPageGeneral.TabIndex = 0;
            this.TabPageGeneral.Text = "Datos";
            this.TabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // TabControlClient
            // 
            this.TabControlClient.Controls.Add(this.TabPageGeneral);
            this.TabControlClient.Controls.Add(this.TabPageAccounts);
            this.TabControlClient.Controls.Add(this.TabPageCards);
            this.TabControlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlClient.Location = new System.Drawing.Point(0, 0);
            this.TabControlClient.Name = "TabControlClient";
            this.TabControlClient.SelectedIndex = 0;
            this.TabControlClient.Size = new System.Drawing.Size(573, 265);
            this.TabControlClient.TabIndex = 2;
            this.TabControlClient.SelectedIndexChanged += new System.EventHandler(this.TabControlClient_SelectedIndexChanged);
            // 
            // ClientEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControlClient);
            this.Controls.Add(this.PanelAction);
            this.Name = "ClientEditor";
            this.Size = new System.Drawing.Size(573, 297);
            this.Load += new System.EventHandler(this.ClientEditor_Load);
            this.PanelAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCards)).EndInit();
            this.TabPageCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAccounts)).EndInit();
            this.TabPageAccounts.ResumeLayout(false);
            this.TabPageGeneral.ResumeLayout(false);
            this.TabPageGeneral.PerformLayout();
            this.TabControlClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button ButtonAccept;
        internal System.Windows.Forms.Panel PanelAction;
        internal System.Windows.Forms.Button ButtonCancel;
        internal System.Windows.Forms.DataGridViewComboBoxColumn CollumnCardAccount2;
        internal System.Windows.Forms.DataGridViewComboBoxColumn CollumnCardAccount1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn CollumnCardExp;
        internal System.Windows.Forms.DataGridViewTextBoxColumn CollumnCardPassword;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnCardNumber;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnBank;
        internal System.Windows.Forms.DataGridView DataGridViewCards;
        internal System.Windows.Forms.TabPage TabPageCards;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccountBalance;
        internal System.Windows.Forms.DataGridViewComboBoxColumn ColumnAccountType;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccountBank;
        internal System.Windows.Forms.DataGridView DataGridViewAccounts;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccountNumber;
        internal System.Windows.Forms.TabPage TabPageAccounts;
        internal System.Windows.Forms.TextBox TextBoxIdentification;
        internal System.Windows.Forms.TextBox TextBoxFullName;
        internal System.Windows.Forms.Label LabelIdentification;
        internal System.Windows.Forms.Label LabelFullName;
        internal System.Windows.Forms.TabPage TabPageGeneral;
        internal System.Windows.Forms.TabControl TabControlClient;
    }
}
