namespace Calculadora
{
    partial class fmrTimers
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
            this.btnAlarma = new System.Windows.Forms.Button();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(92, 81);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(629, 163);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "00:00:00";
            // 
            // btnAlarma
            // 
            this.btnAlarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarma.Location = new System.Drawing.Point(299, 293);
            this.btnAlarma.Name = "btnAlarma";
            this.btnAlarma.Size = new System.Drawing.Size(169, 76);
            this.btnAlarma.TabIndex = 1;
            this.btnAlarma.Text = "Alarma";
            this.btnAlarma.UseVisualStyleBackColor = true;
            this.btnAlarma.Click += new System.EventHandler(this.btnAlarma_Click);
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // fmrTimers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlarma);
            this.Controls.Add(this.lblHora);
            this.Name = "fmrTimers";
            this.Text = "Temporizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnAlarma;
        private System.Windows.Forms.Timer tmrHora;
    }
}