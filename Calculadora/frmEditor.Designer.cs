namespace Calculadora
{
    partial class Editor
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
            this.mnuEditor = new System.Windows.Forms.MenuStrip();
            this.archivo3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsNotificacion = new System.Windows.Forms.StatusStrip();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.oofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuEditor
            // 
            this.mnuEditor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo3ToolStripMenuItem});
            this.mnuEditor.Location = new System.Drawing.Point(0, 0);
            this.mnuEditor.Name = "mnuEditor";
            this.mnuEditor.Size = new System.Drawing.Size(800, 28);
            this.mnuEditor.TabIndex = 0;
            this.mnuEditor.Text = "menuStrip1";
            // 
            // archivo3ToolStripMenuItem
            // 
            this.archivo3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivo3ToolStripMenuItem.Name = "archivo3ToolStripMenuItem";
            this.archivo3ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivo3ToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // rtbEditor
            // 
            this.rtbEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEditor.Location = new System.Drawing.Point(0, 28);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(800, 422);
            this.rtbEditor.TabIndex = 1;
            this.rtbEditor.Text = "";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirToolStripMenuItem.Text = "A&brir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardarComoToolStripMenuItem.Text = "G&uardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // stsNotificacion
            // 
            this.stsNotificacion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsNotificacion.Location = new System.Drawing.Point(0, 428);
            this.stsNotificacion.Name = "stsNotificacion";
            this.stsNotificacion.Size = new System.Drawing.Size(800, 22);
            this.stsNotificacion.TabIndex = 2;
            this.stsNotificacion.Text = "statusStrip1";
            // 
            // sfdGuardar
            // 
            this.sfdGuardar.Filter = "Archivos de Texto|*.txt";
            // 
            // oofdAbrir
            // 
            this.oofdAbrir.FileName = "openFileDialog1";
            this.oofdAbrir.Filter = "Archivos de Texto|*.txt";
            this.oofdAbrir.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imprimirToolStripMenuItem.Text = "&Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stsNotificacion);
            this.Controls.Add(this.rtbEditor);
            this.Controls.Add(this.mnuEditor);
            this.MainMenuStrip = this.mnuEditor;
            this.Name = "Editor";
            this.Text = "frmEditor";
            this.mnuEditor.ResumeLayout(false);
            this.mnuEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuEditor;
        private System.Windows.Forms.ToolStripMenuItem archivo3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.StatusStrip stsNotificacion;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
        private System.Windows.Forms.OpenFileDialog oofdAbrir;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
    }
}