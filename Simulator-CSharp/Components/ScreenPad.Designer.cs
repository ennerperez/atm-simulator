namespace ATM.Components
{
    partial class ScreenPad
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
            this.tableLayoutPanelActions = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAction1 = new ATM.Controls.Button();
            this.buttonAction2 = new ATM.Controls.Button();
            this.buttonAction3 = new ATM.Controls.Button();
            this.buttonAction4 = new ATM.Controls.Button();
            this.tableLayoutPanelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelActions
            // 
            this.tableLayoutPanelActions.ColumnCount = 1;
            this.tableLayoutPanelActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelActions.Controls.Add(this.buttonAction1, 0, 3);
            this.tableLayoutPanelActions.Controls.Add(this.buttonAction2, 0, 2);
            this.tableLayoutPanelActions.Controls.Add(this.buttonAction3, 0, 1);
            this.tableLayoutPanelActions.Controls.Add(this.buttonAction4, 0, 0);
            this.tableLayoutPanelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelActions.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelActions.Name = "tableLayoutPanelActions";
            this.tableLayoutPanelActions.RowCount = 4;
            this.tableLayoutPanelActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelActions.Size = new System.Drawing.Size(64, 260);
            this.tableLayoutPanelActions.TabIndex = 0;
            // 
            // buttonAction1
            // 
            this.buttonAction1.BackColor = System.Drawing.Color.Silver;
            this.buttonAction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAction1.FlatAppearance.BorderSize = 0;
            this.buttonAction1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonAction1.Location = new System.Drawing.Point(3, 198);
            this.buttonAction1.Name = "buttonAction1";
            this.buttonAction1.Size = new System.Drawing.Size(58, 59);
            this.buttonAction1.TabIndex = 0;
            this.buttonAction1.TabStop = false;
            this.buttonAction1.Tag = "1";
            this.buttonAction1.UseVisualStyleBackColor = false;
            this.buttonAction1.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonAction2
            // 
            this.buttonAction2.BackColor = System.Drawing.Color.Silver;
            this.buttonAction2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAction2.FlatAppearance.BorderSize = 0;
            this.buttonAction2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonAction2.Location = new System.Drawing.Point(3, 133);
            this.buttonAction2.Name = "buttonAction2";
            this.buttonAction2.Size = new System.Drawing.Size(58, 59);
            this.buttonAction2.TabIndex = 0;
            this.buttonAction2.TabStop = false;
            this.buttonAction2.Tag = "2";
            this.buttonAction2.UseVisualStyleBackColor = false;
            this.buttonAction2.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonAction3
            // 
            this.buttonAction3.BackColor = System.Drawing.Color.Silver;
            this.buttonAction3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAction3.FlatAppearance.BorderSize = 0;
            this.buttonAction3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonAction3.Location = new System.Drawing.Point(3, 68);
            this.buttonAction3.Name = "buttonAction3";
            this.buttonAction3.Size = new System.Drawing.Size(58, 59);
            this.buttonAction3.TabIndex = 0;
            this.buttonAction3.TabStop = false;
            this.buttonAction3.Tag = "3";
            this.buttonAction3.UseVisualStyleBackColor = false;
            this.buttonAction3.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonAction4
            // 
            this.buttonAction4.BackColor = System.Drawing.Color.Silver;
            this.buttonAction4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAction4.FlatAppearance.BorderSize = 0;
            this.buttonAction4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAction4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonAction4.Location = new System.Drawing.Point(3, 3);
            this.buttonAction4.Name = "buttonAction4";
            this.buttonAction4.Size = new System.Drawing.Size(58, 59);
            this.buttonAction4.TabIndex = 0;
            this.buttonAction4.TabStop = false;
            this.buttonAction4.Tag = "4";
            this.buttonAction4.UseVisualStyleBackColor = false;
            this.buttonAction4.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // screenPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelActions);
            this.Name = "screenPad";
            this.Size = new System.Drawing.Size(64, 260);
            this.tableLayoutPanelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanelActions;
        private Controls.Button buttonAction1;
        private Controls.Button buttonAction2;
        private Controls.Button buttonAction3;
        private Controls.Button buttonAction4;
    }
}
