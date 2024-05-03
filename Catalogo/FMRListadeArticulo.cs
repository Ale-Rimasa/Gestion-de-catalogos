using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Acciones;

namespace Catalogo
{
    public partial class FMRListadeArticulo : Form
    {
        private List<Articulo> listarArticulo;
        public FMRListadeArticulo()
        {
            InitializeComponent();
        }

            Controller conecArti= new Controller();
        private void FMRListadeArticulo_Load(object sender, EventArgs e)
        {
            listarArticulo = conecArti.ListarArticulo();
            DGVArticulosLista.DataSource = listarArticulo;
            DGVArticulosLista.Columns[0].Visible = false;
            DGVArticulosLista.Columns[4].Visible = false;
            DGVArticulosLista.Columns["IDCategoria"].Visible = false;
            DGVArticulosLista.Columns["Imagen"].Visible = false;
        }

        private void DGVArticulosLista_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Articulo seleccionado = (Articulo)DGVArticulosLista.CurrentRow.DataBoundItem;
            VistaArticuloYDetalle ventanaDeArt = new VistaArticuloYDetalle();
            ventanaDeArt.objArticulo = seleccionado;
            ventanaDeArt.ShowDialog();
            
        }


    }
}
