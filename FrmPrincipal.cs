using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca2021;

namespace Biblioteca.GUI
{
    public partial class FrmPrincipal : Form
    {
        FrmAgregaLibros frmAgregaLibros;
        FrmAgregaAutor frmAgregaAutor;
        FrmAgregaLector frmAgregaLector;

        List<Libro> libros = new List<Libro>();
        List<Autor> autores = new List<Autor>();
        List<Lector> lectores = new List<Lector>();

        public void AgregaLibro(Libro libroT)
        {
            libros.Add(libroT);
        }

        public void AgregaAutor(Autor autorT)
        {
            autores.Add(autorT);
        }

        public void AgregaLector(Lector lectorT)
        {
            lectores.Add(lectorT);
        }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void agregarAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAgregaAutor == null)
                frmAgregaAutor = new FrmAgregaAutor();
            else if (frmAgregaAutor.IsDisposed)
                frmAgregaAutor = new FrmAgregaAutor();

            frmAgregaAutor.MdiParent = this;
            frmAgregaAutor.Show();
        }

        private void agregarLectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAgregaLector == null)
                frmAgregaLector = new FrmAgregaLector();
            else if (frmAgregaLector.IsDisposed)
                frmAgregaLector = new FrmAgregaLector();

            frmAgregaLector.MdiParent = this;
            frmAgregaLector.Show();
        }

        private void toolStripMenuItemAgregarLibros_Click_1(object sender, EventArgs e)
        {
            if (frmAgregaLibros == null)
                frmAgregaLibros = new FrmAgregaLibros();
            else if (frmAgregaLibros.IsDisposed)
                frmAgregaLibros = new FrmAgregaLibros();

            frmAgregaLibros.SetFrmPrincipal(this);
            frmAgregaLibros.MdiParent = this;
            frmAgregaLibros.Show();
        }
    }
}
