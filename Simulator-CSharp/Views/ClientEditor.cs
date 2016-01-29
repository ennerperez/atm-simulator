using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM.Views
{
    public partial class ClientEditor : UserControl
    {
       
        public Models.Client Client { get; set; }
        
        public ClientEditor()
        {
            // Esta llamada es exigida por el diseñador.
            InitializeComponent();

            // Agregue cualquier inicialización después de la llamada a InitializeComponent().

            // Grids
            this.DataGridViewAccounts.AutoGenerateColumns = false;
            this.DataGridViewCards.AutoGenerateColumns = false;

            this.Client = new Models.Client();

        }

        public ClientEditor(Models.Client client) : this()
        {
            this.Client = client;
        }

        // ERROR: Handles clauses are not supported in C#
        private void ClientEditor_Load(object sender, EventArgs e)
        {
            this.TextBoxFullName.Text = Client.Name;
            this.TextBoxIdentification.Text = Client.Identification;
            this.DataGridViewAccounts.DataSource = Client.Accounts;
            this.DataGridViewCards.DataSource = Client.Cards;
        }

        // ERROR: Handles clauses are not supported in C#
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        // ERROR: Handles clauses are not supported in C#
        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            //SAVE
            if (Saved != null)
            {
                Saved(this.Client, EventArgs.Empty);
            }
            this.ButtonCancel.PerformClick();
        }

        public event EventHandler Saved;

        private void TabControlClient_SelectedIndexChanged(Object sender, EventArgs e )
        {
            if (object.ReferenceEquals(this.TabControlClient.SelectedTab, this.TabPageCards))
            {
                this.CollumnCardAccount1.DataSource = (from item in Client.Accounts where item.Type == "Ahorro" select item).ToList();
                this.CollumnCardAccount1.DisplayMember = "Number";
                this.CollumnCardAccount1.ValueMember = "Number";
                this.CollumnCardAccount2.DataSource = (from item in Client.Accounts where item.Type == "Corriente" select item).ToList();
                this.CollumnCardAccount2.DisplayMember = "Number";
                this.CollumnCardAccount2.ValueMember = "Number";
            }
        }

        // ERROR: Handles clauses are not supported in C#
        private void DataGridViewCards_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

    }
}
