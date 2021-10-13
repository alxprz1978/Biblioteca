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
    public partial class FrmAgregaLibros : Form
    {
        FrmPrincipal frmPrincipal; //Esta es una referencia

        public void SetFrmPrincipal(FrmPrincipal _frmPrincipal)
        {
            frmPrincipal = _frmPrincipal;
        }
        
        public FrmAgregaLibros()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Libro libroT = new Libro();
            libroT.ISBN = txtISBN.Text;
            libroT.Titulo = txtTitulo.Text;
            libroT.Editorial = txtEditorial.Text;
            libroT.Autor = new Autor();
            libroT.Autor.Nombre = txtAutor.Text;
            libroT.Anio = Convert.ToInt32(txtAño.Text);
            libroT.Precio = Convert.ToSingle(txtPrecio.Text);

            frmPrincipal.AgregaLibro(libroT);
        }
    }
}
