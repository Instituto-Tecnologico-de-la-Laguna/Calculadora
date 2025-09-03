namespace Calculadora
{
    partial class Temporizador
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
            this.lblhrs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblhrs
            // 
            this.lblhrs.AutoSize = true;
            this.lblhrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhrs.Location = new System.Drawing.Point(73, 50);
            this.lblhrs.Name = "lblhrs";
            this.lblhrs.Size = new System.Drawing.Size(355, 91);
            this.lblhrs.TabIndex = 0;
            this.lblhrs.Text = "00:00:00";
            this.lblhrs.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Temporizador
            // 
            this.ClientSize = new System.Drawing.Size(512, 253);
            this.Controls.Add(this.lblhrs);
            this.Name = "Temporizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Button Alarma;
        private System.Windows.Forms.Label lblhrs;
    }
}