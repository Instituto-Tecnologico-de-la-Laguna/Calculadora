namespace Calculadora
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temporizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaDe2NumerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilos2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.appsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // appsToolStripMenuItem
            // 
            this.appsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temporizadorToolStripMenuItem,
            this.sumaDe2NumerosToolStripMenuItem,
            this.helloWorldToolStripMenuItem,
            this.editorDeTextoToolStripMenuItem,
            this.telefonoToolStripMenuItem,
            this.variosToolStripMenuItem,
            this.hilosToolStripMenuItem,
            this.hilos2ToolStripMenuItem});
            this.appsToolStripMenuItem.Name = "appsToolStripMenuItem";
            this.appsToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.appsToolStripMenuItem.Text = "Apps";
            // 
            // temporizadorToolStripMenuItem
            // 
            this.temporizadorToolStripMenuItem.Name = "temporizadorToolStripMenuItem";
            this.temporizadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temporizadorToolStripMenuItem.Text = "Temporizador";
            this.temporizadorToolStripMenuItem.Click += new System.EventHandler(this.temporizadorToolStripMenuItem_Click);
            // 
            // sumaDe2NumerosToolStripMenuItem
            // 
            this.sumaDe2NumerosToolStripMenuItem.Name = "sumaDe2NumerosToolStripMenuItem";
            this.sumaDe2NumerosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumaDe2NumerosToolStripMenuItem.Text = "Suma de 2 numeros";
            this.sumaDe2NumerosToolStripMenuItem.Click += new System.EventHandler(this.sumaDe2NumerosToolStripMenuItem_Click);
            // 
            // helloWorldToolStripMenuItem
            // 
            this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helloWorldToolStripMenuItem.Text = "Hello World";
            this.helloWorldToolStripMenuItem.Click += new System.EventHandler(this.helloWorldToolStripMenuItem_Click);
            // 
            // editorDeTextoToolStripMenuItem
            // 
            this.editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            this.editorDeTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editorDeTextoToolStripMenuItem.Text = "Editor de Texto";
            this.editorDeTextoToolStripMenuItem.Click += new System.EventHandler(this.editorDeTextoToolStripMenuItem_Click);
            // 
            // telefonoToolStripMenuItem
            // 
            this.telefonoToolStripMenuItem.Name = "telefonoToolStripMenuItem";
            this.telefonoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.telefonoToolStripMenuItem.Text = "Telefono";
            this.telefonoToolStripMenuItem.Click += new System.EventHandler(this.telefonoToolStripMenuItem_Click);
            // 
            // variosToolStripMenuItem
            // 
            this.variosToolStripMenuItem.Name = "variosToolStripMenuItem";
            this.variosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.variosToolStripMenuItem.Text = "Varios";
            this.variosToolStripMenuItem.Click += new System.EventHandler(this.variosToolStripMenuItem_Click);
            // 
            // hilosToolStripMenuItem
            // 
            this.hilosToolStripMenuItem.Name = "hilosToolStripMenuItem";
            this.hilosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hilosToolStripMenuItem.Text = "Hilos";
            this.hilosToolStripMenuItem.Click += new System.EventHandler(this.hilosToolStripMenuItem_Click);
            // 
            // hilos2ToolStripMenuItem
            // 
            this.hilos2ToolStripMenuItem.Name = "hilos2ToolStripMenuItem";
            this.hilos2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hilos2ToolStripMenuItem.Text = "Hilos2";
            this.hilos2ToolStripMenuItem.Click += new System.EventHandler(this.hilos2ToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenu";
            this.Text = "Menu de Aplicaciones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temporizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaDe2NumerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilos2ToolStripMenuItem;
    }
}