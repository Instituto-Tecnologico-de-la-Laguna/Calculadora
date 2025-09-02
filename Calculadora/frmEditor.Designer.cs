namespace Calculadora
{
    partial class frmEditor
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
            this.menuEditor = new System.Windows.Forms.MenuStrip();
            this.rbtEditor = new System.Windows.Forms.RichTextBox();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusNotificacion = new System.Windows.Forms.StatusStrip();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuEditor
            // 
            this.menuEditor.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuEditor.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuEditor.Location = new System.Drawing.Point(0, 0);
            this.menuEditor.Name = "menuEditor";
            this.menuEditor.Size = new System.Drawing.Size(800, 33);
            this.menuEditor.TabIndex = 0;
            this.menuEditor.Text = "menuStrip1";
            // 
            // rbtEditor
            // 
            this.rbtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtEditor.Location = new System.Drawing.Point(0, 33);
            this.rbtEditor.Name = "rbtEditor";
            this.rbtEditor.Size = new System.Drawing.Size(800, 417);
            this.rbtEditor.TabIndex = 1;
            this.rbtEditor.Text = "";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.nuevoToolStripMenuItem.Text = "N&uevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // statusNotificacion
            // 
            this.statusNotificacion.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusNotificacion.Location = new System.Drawing.Point(0, 428);
            this.statusNotificacion.Name = "statusNotificacion";
            this.statusNotificacion.Size = new System.Drawing.Size(800, 22);
            this.statusNotificacion.TabIndex = 2;
            this.statusNotificacion.Text = "statusStrip1";
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.Filter = "Archivos de Texto|*.txt";
            // 
            // sfdGuardar
            // 
            this.sfdGuardar.Filter = "Archivos de Texto|*.txt";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusNotificacion);
            this.Controls.Add(this.rbtEditor);
            this.Controls.Add(this.menuEditor);
            this.MainMenuStrip = this.menuEditor;
            this.Name = "frmEditor";
            this.Text = "frmEditor";
            this.menuEditor.ResumeLayout(false);
            this.menuEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuEditor;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rbtEditor;
        private System.Windows.Forms.StatusStrip statusNotificacion;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}