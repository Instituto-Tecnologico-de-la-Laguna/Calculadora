namespace Aplicacion2
{
    partial class Form3
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
            this.labHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAlarma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labHora
            // 
            this.labHora.AutoSize = true;
            this.labHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHora.Location = new System.Drawing.Point(140, 98);
            this.labHora.Name = "labHora";
            this.labHora.Size = new System.Drawing.Size(417, 108);
            this.labHora.TabIndex = 0;
            this.labHora.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAlarma
            // 
            this.btnAlarma.Location = new System.Drawing.Point(12, 314);
            this.btnAlarma.Name = "btnAlarma";
            this.btnAlarma.Size = new System.Drawing.Size(161, 73);
            this.btnAlarma.TabIndex = 1;
            this.btnAlarma.Text = "ALARMA";
            this.btnAlarma.UseVisualStyleBackColor = true;
            this.btnAlarma.Click += new System.EventHandler(this.btnAlarma_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlarma);
            this.Controls.Add(this.labHora);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAlarma;
    }
}