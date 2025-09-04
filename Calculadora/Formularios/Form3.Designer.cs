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
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.btnAlarma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(121, 51);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(284, 73);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "00:00:00";
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAlarma
            // 
            this.btnAlarma.Location = new System.Drawing.Point(12, 226);
            this.btnAlarma.Name = "btnAlarma";
            this.btnAlarma.Size = new System.Drawing.Size(108, 49);
            this.btnAlarma.TabIndex = 1;
            this.btnAlarma.Text = "Alarma";
            this.btnAlarma.UseVisualStyleBackColor = true;
            this.btnAlarma.Click += new System.EventHandler(this.btnAlarma_Click);
            // 
            // frmTimers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 331);
            this.Controls.Add(this.btnAlarma);
            this.Controls.Add(this.lblHora);
            this.Name = "frmTimers";
            this.Text = "Temporizadores";
            this.Load += new System.EventHandler(this.frmTimers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Button btnAlarma;
    }
}