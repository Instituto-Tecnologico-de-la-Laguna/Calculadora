namespace Calculadora
{
    partial class Form2
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
            this.textValor1 = new System.Windows.Forms.TextBox();
            this.textValor2 = new System.Windows.Forms.TextBox();
            this.e = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sumarval = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textValor1
            // 
            this.textValor1.Location = new System.Drawing.Point(64, 74);
            this.textValor1.Name = "textValor1";
            this.textValor1.Size = new System.Drawing.Size(100, 22);
            this.textValor1.TabIndex = 0;
            // 
            // textValor2
            // 
            this.textValor2.Location = new System.Drawing.Point(64, 185);
            this.textValor2.Name = "textValor2";
            this.textValor2.Size = new System.Drawing.Size(100, 22);
            this.textValor2.TabIndex = 1;
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(61, 45);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(49, 16);
            this.e.TabIndex = 2;
            this.e.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor 2";
            // 
            // sumarval
            // 
            this.sumarval.Location = new System.Drawing.Point(64, 242);
            this.sumarval.Name = "sumarval";
            this.sumarval.Size = new System.Drawing.Size(98, 23);
            this.sumarval.TabIndex = 4;
            this.sumarval.Text = "CALCULAR";
            this.sumarval.UseVisualStyleBackColor = true;
            this.sumarval.Click += new System.EventHandler(this.sumarval_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 318);
            this.Controls.Add(this.sumarval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.e);
            this.Controls.Add(this.textValor2);
            this.Controls.Add(this.textValor1);
            this.Name = "Form2";
            this.Text = "Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textValor1;
        private System.Windows.Forms.TextBox textValor2;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sumarval;
    }
}