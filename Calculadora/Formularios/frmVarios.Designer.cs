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
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbBit4 = new System.Windows.Forms.CheckBox();
            this.chbBit3 = new System.Windows.Forms.CheckBox();
            this.chbBit2 = new System.Windows.Forms.CheckBox();
            this.chbBit1 = new System.Windows.Forms.CheckBox();
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
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 551);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.cmbColores);
            this.tabPage1.Controls.Add(this.btnEnviar);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 518);
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
            this.tabPage2.Size = new System.Drawing.Size(866, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Opciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(468, 307);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(347, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(468, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // cmbColores
            // 
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Items.AddRange(new object[] {
            "Azul",
            "Amarrillo",
            "Rosa",
            "Rojo",
            "Verde",
            "Cafe",
            "Morado"});
            this.cmbColores.Location = new System.Drawing.Point(34, 232);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(303, 28);
            this.cmbColores.TabIndex = 12;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(82, 359);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(266, 35);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbMujer);
            this.groupBox2.Controls.Add(this.rdbHombre);
            this.groupBox2.Location = new System.Drawing.Point(234, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 135);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccion";
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Location = new System.Drawing.Point(23, 64);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(73, 24);
            this.rdbMujer.TabIndex = 3;
            this.rdbMujer.Text = "Mujer";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Checked = true;
            this.rdbHombre.Location = new System.Drawing.Point(23, 25);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(91, 24);
            this.rdbHombre.TabIndex = 2;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Hombre";
            this.rdbHombre.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbBit4);
            this.groupBox1.Controls.Add(this.chbBit3);
            this.groupBox1.Controls.Add(this.chbBit2);
            this.groupBox1.Controls.Add(this.chbBit1);
            this.groupBox1.Location = new System.Drawing.Point(34, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 164);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Binario";
            // 
            // chbBit4
            // 
            this.chbBit4.AutoSize = true;
            this.chbBit4.Location = new System.Drawing.Point(25, 125);
            this.chbBit4.Name = "chbBit4";
            this.chbBit4.Size = new System.Drawing.Size(67, 24);
            this.chbBit4.TabIndex = 3;
            this.chbBit4.Text = "Bit 4";
            this.chbBit4.UseVisualStyleBackColor = true;
            // 
            // chbBit3
            // 
            this.chbBit3.AutoSize = true;
            this.chbBit3.Location = new System.Drawing.Point(25, 95);
            this.chbBit3.Name = "chbBit3";
            this.chbBit3.Size = new System.Drawing.Size(67, 24);
            this.chbBit3.TabIndex = 2;
            this.chbBit3.Text = "Bit 3";
            this.chbBit3.UseVisualStyleBackColor = true;
            // 
            // chbBit2
            // 
            this.chbBit2.AutoSize = true;
            this.chbBit2.Location = new System.Drawing.Point(25, 65);
            this.chbBit2.Name = "chbBit2";
            this.chbBit2.Size = new System.Drawing.Size(67, 24);
            this.chbBit2.TabIndex = 1;
            this.chbBit2.Text = "Bit 2";
            this.chbBit2.UseVisualStyleBackColor = true;
            // 
            // chbBit1
            // 
            this.chbBit1.AutoSize = true;
            this.chbBit1.Location = new System.Drawing.Point(25, 35);
            this.chbBit1.Name = "chbBit1";
            this.chbBit1.Size = new System.Drawing.Size(67, 24);
            this.chbBit1.TabIndex = 0;
            this.chbBit1.Text = "Bit 1";
            this.chbBit1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(6, 47);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(857, 447);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.hola.com", System.UriKind.Absolute);
            // 
            // frmVarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 549);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmVarios";
            this.Text = "Componentes Varios";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbBit4;
        private System.Windows.Forms.CheckBox chbBit3;
        private System.Windows.Forms.CheckBox chbBit2;
        private System.Windows.Forms.CheckBox chbBit1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}