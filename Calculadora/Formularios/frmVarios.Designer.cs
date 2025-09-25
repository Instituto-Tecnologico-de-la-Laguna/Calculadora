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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chbBit1 = new System.Windows.Forms.CheckBox();
            this.chbBit2 = new System.Windows.Forms.CheckBox();
            this.chbBit3 = new System.Windows.Forms.CheckBox();
            this.chbBit4 = new System.Windows.Forms.CheckBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.labColores = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Varios = new System.Windows.Forms.TabControl();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Varios.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbBit4);
            this.groupBox1.Controls.Add(this.chbBit3);
            this.groupBox1.Controls.Add(this.chbBit2);
            this.groupBox1.Controls.Add(this.chbBit1);
            this.groupBox1.Location = new System.Drawing.Point(20, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Binarios";
            // 
            // chbBit1
            // 
            this.chbBit1.AutoSize = true;
            this.chbBit1.Location = new System.Drawing.Point(10, 19);
            this.chbBit1.Name = "chbBit1";
            this.chbBit1.Size = new System.Drawing.Size(46, 17);
            this.chbBit1.TabIndex = 1;
            this.chbBit1.Text = "bit 1";
            this.chbBit1.UseVisualStyleBackColor = true;
            // 
            // chbBit2
            // 
            this.chbBit2.AutoSize = true;
            this.chbBit2.Location = new System.Drawing.Point(10, 42);
            this.chbBit2.Name = "chbBit2";
            this.chbBit2.Size = new System.Drawing.Size(46, 17);
            this.chbBit2.TabIndex = 2;
            this.chbBit2.Text = "bit 2";
            this.chbBit2.UseVisualStyleBackColor = true;
            // 
            // chbBit3
            // 
            this.chbBit3.AutoSize = true;
            this.chbBit3.Location = new System.Drawing.Point(10, 65);
            this.chbBit3.Name = "chbBit3";
            this.chbBit3.Size = new System.Drawing.Size(46, 17);
            this.chbBit3.TabIndex = 1;
            this.chbBit3.Text = "bit 3";
            this.chbBit3.UseVisualStyleBackColor = true;
            // 
            // chbBit4
            // 
            this.chbBit4.AutoSize = true;
            this.chbBit4.Location = new System.Drawing.Point(10, 88);
            this.chbBit4.Name = "chbBit4";
            this.chbBit4.Size = new System.Drawing.Size(46, 17);
            this.chbBit4.TabIndex = 1;
            this.chbBit4.Text = "bit 4";
            this.chbBit4.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(183, 284);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(262, 43);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbMujer);
            this.groupBox2.Controls.Add(this.rdbHombre);
            this.groupBox2.Location = new System.Drawing.Point(203, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccion";
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Location = new System.Drawing.Point(6, 19);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(62, 17);
            this.rdbHombre.TabIndex = 0;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Hombre";
            this.rdbHombre.UseVisualStyleBackColor = true;
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Location = new System.Drawing.Point(6, 42);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(51, 17);
            this.rdbMujer.TabIndex = 1;
            this.rdbMujer.TabStop = true;
            this.rdbMujer.Text = "Mujer";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // labColores
            // 
            this.labColores.AutoSize = true;
            this.labColores.Location = new System.Drawing.Point(17, 200);
            this.labColores.Name = "labColores";
            this.labColores.Size = new System.Drawing.Size(42, 13);
            this.labColores.TabIndex = 2;
            this.labColores.Text = "Colores";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Azul",
            "Rojo",
            "Capibara",
            "Amarillo",
            "Negro",
            "Blanco"});
            this.comboBox1.Location = new System.Drawing.Point(20, 216);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Varios
            // 
            this.Varios.Controls.Add(this.tabPage2);
            this.Varios.Controls.Add(this.tabPage1);
            this.Varios.Location = new System.Drawing.Point(0, -1);
            this.Varios.Name = "Varios";
            this.Varios.SelectedIndex = 0;
            this.Varios.Size = new System.Drawing.Size(649, 457);
            this.Varios.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(409, 6);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(409, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.btnEnviar);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.monthCalendar1);
            this.tabPage2.Controls.Add(this.labColores);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Varios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 431);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Opciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmVarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.Varios);
            this.Name = "frmVarios";
            this.Text = "Componentes Varios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Varios.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbBit1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox chbBit4;
        private System.Windows.Forms.CheckBox chbBit3;
        private System.Windows.Forms.CheckBox chbBit2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.Label labColores;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl Varios;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage tabPage1;
    }
}