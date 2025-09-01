namespace Calculadora
{
    partial class FrmTimers
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
            this.LblHora = new System.Windows.Forms.Label();
            this.TmrHora = new System.Windows.Forms.Timer(this.components);
            this.BtnAlarma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(49, 60);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(417, 108);
            this.LblHora.TabIndex = 0;
            this.LblHora.Text = "00:00:00";
            this.LblHora.Click += new System.EventHandler(this.label1_Click);
            // 
            // TmrHora
            // 
            this.TmrHora.Enabled = true;
            this.TmrHora.Interval = 1000;
            this.TmrHora.Tick += new System.EventHandler(this.TmrHora_Tick);
            // 
            // BtnAlarma
            // 
            this.BtnAlarma.Location = new System.Drawing.Point(45, 238);
            this.BtnAlarma.Name = "BtnAlarma";
            this.BtnAlarma.Size = new System.Drawing.Size(102, 46);
            this.BtnAlarma.TabIndex = 1;
            this.BtnAlarma.Text = "Alarma";
            this.BtnAlarma.UseVisualStyleBackColor = true;
            this.BtnAlarma.Click += new System.EventHandler(this.BtnAlarma_Click);
            // 
            // FrmTimers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 320);
            this.Controls.Add(this.BtnAlarma);
            this.Controls.Add(this.LblHora);
            this.Name = "FrmTimers";
            this.Text = "FrmTimers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer TmrHora;
        private System.Windows.Forms.Button BtnAlarma;
    }
}