
namespace Biblioteca.GUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAgregarLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarLectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuArchivo,
            this.toolStripMenuLibros,
            this.autoresToolStripMenuItem,
            this.lectoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuArchivo
            // 
            this.toolStripMenuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuGuardar,
            this.toolStripSeparator1,
            this.toolStripMenuSalir});
            this.toolStripMenuArchivo.Name = "toolStripMenuArchivo";
            this.toolStripMenuArchivo.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuArchivo.Text = "Archivo";
            // 
            // toolStripMenuGuardar
            // 
            this.toolStripMenuGuardar.Name = "toolStripMenuGuardar";
            this.toolStripMenuGuardar.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuGuardar.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // toolStripMenuSalir
            // 
            this.toolStripMenuSalir.Name = "toolStripMenuSalir";
            this.toolStripMenuSalir.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuSalir.Text = "Salir";
            this.toolStripMenuSalir.Click += new System.EventHandler(this.toolStripMenuSalir_Click);
            // 
            // toolStripMenuLibros
            // 
            this.toolStripMenuLibros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAgregarLibros});
            this.toolStripMenuLibros.Name = "toolStripMenuLibros";
            this.toolStripMenuLibros.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuLibros.Text = "Libros";
            // 
            // toolStripMenuItemAgregarLibros
            // 
            this.toolStripMenuItemAgregarLibros.Name = "toolStripMenuItemAgregarLibros";
            this.toolStripMenuItemAgregarLibros.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemAgregarLibros.Text = "Agregar Libros";
            this.toolStripMenuItemAgregarLibros.Click += new System.EventHandler(this.toolStripMenuItemAgregarLibros_Click_1);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAutorToolStripMenuItem});
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.autoresToolStripMenuItem.Text = "Autores";
            // 
            // agregarAutorToolStripMenuItem
            // 
            this.agregarAutorToolStripMenuItem.Name = "agregarAutorToolStripMenuItem";
            this.agregarAutorToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.agregarAutorToolStripMenuItem.Text = "Agregar Autor";
            this.agregarAutorToolStripMenuItem.Click += new System.EventHandler(this.agregarAutorToolStripMenuItem_Click);
            // 
            // lectoresToolStripMenuItem
            // 
            this.lectoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarLectorToolStripMenuItem});
            this.lectoresToolStripMenuItem.Name = "lectoresToolStripMenuItem";
            this.lectoresToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.lectoresToolStripMenuItem.Text = "Lectores";
            // 
            // agregarLectorToolStripMenuItem
            // 
            this.agregarLectorToolStripMenuItem.Name = "agregarLectorToolStripMenuItem";
            this.agregarLectorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarLectorToolStripMenuItem.Text = "Agregar Lector";
            this.agregarLectorToolStripMenuItem.Click += new System.EventHandler(this.agregarLectorToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 473);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Biblioteca 2021";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        








        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuArchivo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSalir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuLibros;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAgregarLibros;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lectoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarLectorToolStripMenuItem;
    }
}

