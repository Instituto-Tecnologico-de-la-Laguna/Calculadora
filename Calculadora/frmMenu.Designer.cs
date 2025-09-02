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
            this.appsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaDe2NumerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temporizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holaMundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.appsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // appsToolStripMenuItem
            // 
            this.appsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaDe2NumerosToolStripMenuItem,
            this.temporizadorToolStripMenuItem,
            this.holaMundoToolStripMenuItem});
            this.appsToolStripMenuItem.Name = "appsToolStripMenuItem";
            this.appsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.appsToolStripMenuItem.Text = "Apps";
            // 
            // sumaDe2NumerosToolStripMenuItem
            // 
            this.sumaDe2NumerosToolStripMenuItem.Name = "sumaDe2NumerosToolStripMenuItem";
            this.sumaDe2NumerosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.sumaDe2NumerosToolStripMenuItem.Text = "Suma de 2 Numeros";
            this.sumaDe2NumerosToolStripMenuItem.Click += new System.EventHandler(this.sumaDe2NumerosToolStripMenuItem_Click);
            // 
            // temporizadorToolStripMenuItem
            // 
            this.temporizadorToolStripMenuItem.Name = "temporizadorToolStripMenuItem";
            this.temporizadorToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.temporizadorToolStripMenuItem.Text = "Temporizador";
            this.temporizadorToolStripMenuItem.Click += new System.EventHandler(this.temporizadorToolStripMenuItem_Click);
            // 
            // holaMundoToolStripMenuItem
            // 
            this.holaMundoToolStripMenuItem.Name = "holaMundoToolStripMenuItem";
            this.holaMundoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.holaMundoToolStripMenuItem.Text = "Hola Mundo";
            this.holaMundoToolStripMenuItem.Click += new System.EventHandler(this.holaMundoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem appsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaDe2NumerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temporizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holaMundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}