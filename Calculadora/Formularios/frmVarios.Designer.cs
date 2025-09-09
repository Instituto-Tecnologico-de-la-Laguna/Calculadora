namespace Calculadora.Formularios
{
    partial class frmVarios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbdMujer = new System.Windows.Forms.RadioButton();
            this.rbdHombre = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chBit4 = new System.Windows.Forms.CheckBox();
            this.chBit3 = new System.Windows.Forms.CheckBox();
            this.chBit2 = new System.Windows.Forms.CheckBox();
            this.chBit1 = new System.Windows.Forms.CheckBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1154, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbColores);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnEnviar);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1146, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Varios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1146, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Opciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(774, 339);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(347, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(774, 64);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Colores";
            // 
            // cmbColores
            // 
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Items.AddRange(new object[] {
            "Azul",
            "Amarillo",
            "Rojo",
            "Verde",
            "Morado",
            "Negro",
            "Cafe",
            "Gris"});
            this.cmbColores.Location = new System.Drawing.Point(455, 80);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(231, 28);
            this.cmbColores.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbdMujer);
            this.groupBox2.Controls.Add(this.rbdHombre);
            this.groupBox2.Location = new System.Drawing.Point(249, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 209);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccion";
            // 
            // rbdMujer
            // 
            this.rbdMujer.AutoSize = true;
            this.rbdMujer.Location = new System.Drawing.Point(7, 56);
            this.rbdMujer.Name = "rbdMujer";
            this.rbdMujer.Size = new System.Drawing.Size(73, 24);
            this.rbdMujer.TabIndex = 1;
            this.rbdMujer.TabStop = true;
            this.rbdMujer.Text = "Mujer";
            this.rbdMujer.UseVisualStyleBackColor = true;
            // 
            // rbdHombre
            // 
            this.rbdHombre.AutoSize = true;
            this.rbdHombre.Location = new System.Drawing.Point(7, 26);
            this.rbdHombre.Name = "rbdHombre";
            this.rbdHombre.Size = new System.Drawing.Size(91, 24);
            this.rbdHombre.TabIndex = 0;
            this.rbdHombre.TabStop = true;
            this.rbdHombre.Text = "Hombre";
            this.rbdHombre.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chBit4);
            this.groupBox1.Controls.Add(this.chBit3);
            this.groupBox1.Controls.Add(this.chBit2);
            this.groupBox1.Controls.Add(this.chBit1);
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 219);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Binario";
            // 
            // chBit4
            // 
            this.chBit4.AutoSize = true;
            this.chBit4.Location = new System.Drawing.Point(7, 116);
            this.chBit4.Name = "chBit4";
            this.chBit4.Size = new System.Drawing.Size(61, 24);
            this.chBit4.TabIndex = 4;
            this.chBit4.Text = "bit4";
            this.chBit4.UseVisualStyleBackColor = true;
            // 
            // chBit3
            // 
            this.chBit3.AutoSize = true;
            this.chBit3.Location = new System.Drawing.Point(7, 86);
            this.chBit3.Name = "chBit3";
            this.chBit3.Size = new System.Drawing.Size(61, 24);
            this.chBit3.TabIndex = 3;
            this.chBit3.Text = "bit3";
            this.chBit3.UseVisualStyleBackColor = true;
            // 
            // chBit2
            // 
            this.chBit2.AutoSize = true;
            this.chBit2.Location = new System.Drawing.Point(6, 56);
            this.chBit2.Name = "chBit2";
            this.chBit2.Size = new System.Drawing.Size(61, 24);
            this.chBit2.TabIndex = 2;
            this.chBit2.Text = "bit2";
            this.chBit2.UseVisualStyleBackColor = true;
            // 
            // chBit1
            // 
            this.chBit1.AutoSize = true;
            this.chBit1.Location = new System.Drawing.Point(7, 26);
            this.chBit1.Name = "chBit1";
            this.chBit1.Size = new System.Drawing.Size(61, 24);
            this.chBit1.TabIndex = 0;
            this.chBit1.Text = "bit1";
            this.chBit1.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(197, 280);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(81, 41);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1140, 386);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://www.google.com/?hl=es_419", System.UriKind.Absolute);
            // 
            // frmVarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmVarios";
            this.Text = "Componentes Varios";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbdMujer;
        private System.Windows.Forms.RadioButton rbdHombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chBit4;
        private System.Windows.Forms.CheckBox chBit3;
        private System.Windows.Forms.CheckBox chBit2;
        private System.Windows.Forms.CheckBox chBit1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}