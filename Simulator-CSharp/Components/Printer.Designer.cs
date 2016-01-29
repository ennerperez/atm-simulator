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
            this.timerDiscart = new System.Windows.Forms.Timer(this.components);
            this.timerPrinting = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerDiscart
            // 
            this.timerDiscart.Interval = 3000;
            // 
            // timerPrinting
            // 
            this.timerPrinting.Interval = 3000;
            // 
            // Printer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Printer";
            this.Size = new System.Drawing.Size(150, 34);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerDiscart;
        private System.Windows.Forms.Timer timerPrinting;
    }
}
