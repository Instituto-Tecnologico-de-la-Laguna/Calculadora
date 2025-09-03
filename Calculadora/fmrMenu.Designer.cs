namespace Calculadora
{
    partial class fmrMenu
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
            this.sumaDeDosNumerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarMensajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.appsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(147, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // appsToolStripMenuItem
            // 
            this.appsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temporizadorToolStripMenuItem,
            this.sumaDeDosNumerosToolStripMenuItem,
            this.enviarMensajeToolStripMenuItem,
            this.editorToolStripMenuItem});
            this.appsToolStripMenuItem.Name = "appsToolStripMenuItem";
            this.appsToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.appsToolStripMenuItem.Text = "Apps";
            // 
            // temporizadorToolStripMenuItem
            // 
            this.temporizadorToolStripMenuItem.Name = "temporizadorToolStripMenuItem";
            this.temporizadorToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.temporizadorToolStripMenuItem.Text = "Temporizador";
            this.temporizadorToolStripMenuItem.Click += new System.EventHandler(this.temporizadorToolStripMenuItem_Click);
            // 
            // sumaDeDosNumerosToolStripMenuItem
            // 
            this.sumaDeDosNumerosToolStripMenuItem.Name = "sumaDeDosNumerosToolStripMenuItem";
            this.sumaDeDosNumerosToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.sumaDeDosNumerosToolStripMenuItem.Text = "Suma de dos numeros";
            this.sumaDeDosNumerosToolStripMenuItem.Click += new System.EventHandler(this.sumaDeDosNumerosToolStripMenuItem_Click);
            // 
            // enviarMensajeToolStripMenuItem
            // 
            this.enviarMensajeToolStripMenuItem.Name = "enviarMensajeToolStripMenuItem";
            this.enviarMensajeToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.enviarMensajeToolStripMenuItem.Text = "Enviar Mensaje";
            this.enviarMensajeToolStripMenuItem.Click += new System.EventHandler(this.enviarMensajeToolStripMenuItem_Click);
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.editorToolStripMenuItem.Text = "Editor";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // fmrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmrMenu";
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
        private System.Windows.Forms.ToolStripMenuItem sumaDeDosNumerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarMensajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
    }
}