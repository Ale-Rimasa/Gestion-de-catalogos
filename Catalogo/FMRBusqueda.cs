using Acciones;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Catalogo
{

    public partial class FMRBusqueda : Form
    {
      
       List<Articulo> articulos = new List<Articulo>();
           public Articulo articuloIndividual=new Articulo();
        DataTable dt = new DataTable();
      
       
        VistaArticuloYDetalle objVistarArticulo = new VistaArticuloYDetalle();
        public FMRBusqueda()
        {
            InitializeComponent();
        }

 
        private bool ValidarEntradaTxtBusqueda(string palabraClave)
        {
            if (string.IsNullOrWhiteSpace(palabraClave))
            {
                MessageBox.Show("Por favor ingrese una letra o palabra clave.");
                return false;
            }
            return true;
        }
        public void button1_Click(object sender, EventArgs e)
        {
           
            LBListaBusqueda.Items.Clear();
            if (txtBusqueda.Text == "") {
                MessageBox.Show("Ingrese una palabra");
                return;
            }
            if (!ValidarEntradaTxtBusqueda(txtBusqueda.Text))
            {
                return;
            }
             
            //CAPTURO LA PALABRA Q INGRESO
            string busquedad = txtBusqueda.Text;
            Controller Data= new Controller();
            if (cmboxFiltrado.SelectedIndex == 2 || cmboxFiltrado.SelectedIndex == -1) 
            {
                articulos = Data.Busquedad(busquedad);
            }
            else if (cmboxFiltrado.SelectedIndex == 0) 
            {
                articulos = Data.BuscarporCategoria(busquedad);
            }
            else
            {
                articulos = Data.BuscarporMarca(busquedad); 
            }
           
           
            
            if(articulos.Count == 0)
            {
                MessageBox.Show("Su articulo no se encuentra.");   
                txtBusqueda.Text = "";
                return;
            }

            foreach (Articulo articulo in articulos)
            {
   
                LBListaBusqueda.Items.Add(articulo.Nombre+" - "+ articulo.Marca);
   
            }
            cmboxFiltrado.SelectedIndex = -1;
            cmboxFiltrado.Text = "Filtrar";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void LBListaBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBListaBusqueda.SelectedIndex >= 0)
            {
                //agrego a la clase el incide del artulo para mostrarlo 
                Articulo articuloSeleccionado = articulos[LBListaBusqueda.SelectedIndex];
                articuloIndividual = articuloSeleccionado;
                objVistarArticulo.objArticulo = articuloSeleccionado;
                // Asignar el artículo seleccionado a objArticulo en objVistarArticulo
                LBListaBusqueda.Items.Clear();
                objVistarArticulo.ShowDialog();

            }

        }


        private void cmboxFiltrado_Click(object sender, EventArgs e)
        {

            cmboxFiltrado.Items.Clear();
            cmboxFiltrado.Items.Add("Categoria");
            cmboxFiltrado.Items.Add("Marca");
            cmboxFiltrado.Items.Add("Todo");
        }
    }
}
