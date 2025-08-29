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
            this.V1 = new System.Windows.Forms.TextBox();
            this.V2 = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.valor1 = new System.Windows.Forms.Label();
            this.valor2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // V1
            // 
            this.V1.Location = new System.Drawing.Point(24, 67);
            this.V1.Name = "V1";
            this.V1.Size = new System.Drawing.Size(100, 22);
            this.V1.TabIndex = 0;
            // 
            // V2
            // 
            this.V2.Location = new System.Drawing.Point(24, 146);
            this.V2.Name = "V2";
            this.V2.Size = new System.Drawing.Size(100, 22);
            this.V2.TabIndex = 1;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(200, 97);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 2;
            this.calcular.Text = "calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // valor1
            // 
            this.valor1.AutoSize = true;
            this.valor1.Location = new System.Drawing.Point(21, 39);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(49, 16);
            this.valor1.TabIndex = 4;
            this.valor1.Text = "Valor 1";
            // 
            // valor2
            // 
            this.valor2.AutoSize = true;
            this.valor2.Location = new System.Drawing.Point(21, 117);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(49, 16);
            this.valor2.TabIndex = 5;
            this.valor2.Text = "Valor 2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.V2);
            this.Controls.Add(this.V1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox V1;
        private System.Windows.Forms.TextBox V2;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label valor1;
        private System.Windows.Forms.Label valor2;
    }
}