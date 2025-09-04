namespace Calculadora
{
    partial class frmTimers
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
            this.components = new System.ComponentModel.Container();
            this.lblHora = new System.Windows.Forms.Label();
            this.Interaction = new System.Windows.Forms.Timer(this.components);
            this.btnAlarma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(139, 82);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(69, 20);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "00.00.00";
            // 
            // btnAlarma
            // 
            this.btnAlarma.Location = new System.Drawing.Point(142, 266);
            this.btnAlarma.Name = "btnAlarma";
            this.btnAlarma.Size = new System.Drawing.Size(123, 40);
            this.btnAlarma.TabIndex = 1;
            this.btnAlarma.Text = "button1";
            this.btnAlarma.UseVisualStyleBackColor = true;
            this.btnAlarma.Click += new System.EventHandler(this.btnAlarma_Click_1);
            // 
            // frmTimers
            // 
            this.ClientSize = new System.Drawing.Size(1002, 573);
            this.Controls.Add(this.btnAlarma);
            this.Controls.Add(this.lblHora);
            this.Name = "frmTimers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer Interaction;
        private System.Windows.Forms.Button btnAlarma;
    }
}