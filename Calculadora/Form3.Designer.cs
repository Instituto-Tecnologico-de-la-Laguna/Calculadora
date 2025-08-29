namespace Calculadora
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
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.BOTONSUMAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(31, 80);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(100, 22);
            this.txtvalor1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "VALOR 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "VALOR 2";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(31, 203);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 22);
            this.txtValor2.TabIndex = 4;
            this.txtValor2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BOTONSUMAR
            // 
            this.BOTONSUMAR.Location = new System.Drawing.Point(181, 144);
            this.BOTONSUMAR.Name = "BOTONSUMAR";
            this.BOTONSUMAR.Size = new System.Drawing.Size(75, 23);
            this.BOTONSUMAR.TabIndex = 5;
            this.BOTONSUMAR.Text = "SUMA";
            this.BOTONSUMAR.UseVisualStyleBackColor = true;
            this.BOTONSUMAR.Click += new System.EventHandler(this.BOTONSUMAR_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BOTONSUMAR);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvalor1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button BOTONSUMAR;
    }
}