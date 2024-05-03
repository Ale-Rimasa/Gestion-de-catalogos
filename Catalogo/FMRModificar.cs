using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acciones;
using Dominio;
namespace Catalogo
{
    public partial class FMRModificar : Form
    {
        
        FMRBusqueda BusquedadModificar=new FMRBusqueda();
        Articulo ArticuloModificar=new Articulo();
        Controller conexionART=new Controller();
        List<Articulo>  articulos=new List<Articulo>();
        List<Articulo> Marca=new List<Articulo>();
        List<Articulo> Categoria= new List<Articulo>();

        int seleccionLista=-1;
        public FMRModificar()
        {
            InitializeComponent();

        }
        
        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool StringNoVacio(string a)
        {
            if (a == "")
            {
                return false;
            }
            else { return true; }

        }
        private bool validarCamposTxt()
        {
            EliminarIconosErrorProv();
            bool ok = true;

            if (!StringNoVacio(txtBuscar.Text)) ErrorProvBuscar.SetError(txtBuscar, "Ingrese el campo.");
            if (!StringNoVacio(TXTCodigo.Text)) ErrorProvCod.SetError(TXTCodigo, "Ingrese el Código.");
            if (!StringNoVacio(TXTBDescripcion.Text)) ErrorProvCodDescrip.SetError(TXTBDescripcion, "Ingrese la Descripcion.");

            if (cboBoxBusqueda.SelectedIndex < 0)
            {

                ok = false;
                ErrorProvCboNombre.SetError(cboBoxBusqueda, "Seleccione el nombre.");
            }
            if (CboMarca.SelectedIndex < 0)
            {

                ok = false;
                ErrorProvMarca.SetError(CboMarca, "Seleccione Marca.");
            }
            if (CboCategoria.SelectedIndex < 0)
            {
                ok = false;
                ErrorProvCboCat.SetError(CboCategoria, "Seleccione la Categoria.");
            }
            float numero;
            if (!float.TryParse(TxtPrecio.Text, out numero) || numero < 0)
            {

                ErrorProvCboCat.SetError(TxtPrecio, "Ingrese valor numerico positivo. ");
                TxtPrecio.Clear();
                ok = false;
            }

            if (TxtURL.Text == "" || TxtURL.Text.Length > 999)
            {
                ok = false;
                ErrorProvUrl.SetError(TxtURL, "Ingrese la Url y no puede exceder los 999 caracteres ");
            }
            return ok;
        }

        private void EliminarIconosErrorProv()
        {
            ErrorProvBuscar.SetError(txtBuscar, "");
            ErrorProvCboNombre.SetError(cboBoxBusqueda, "");
            ErrorProvCodDescrip.SetError(TXTBDescripcion, "");
            ErrorProvCod.SetError(TXTCodigo, "");
            ErrorProvMarca.SetError(CboMarca,"");
            ErrorProvCboCat.SetError(CboCategoria, "");
            ErrorProvCboCat.SetError(TxtPrecio, "");
            ErrorProvUrl.SetError(TxtURL, "");

        }

        private void BuscarAmodificar(object sender, EventArgs e)
        {
            cboBoxBusqueda.Items.Clear();
            CboCategoria.Items.Clear();
            CboMarca.Items.Clear(); 
            
            
            List<Articulo> articulosBuscados = new List<Articulo>();

            articulosBuscados= conexionART.Busqueda_Modificar(txtBuscar.Text);

            for (int i = 0; i < articulosBuscados.Count;i ++)
            {
                Articulo aux = articulosBuscados[i];
                if (aux.Nombre != null) { 
                cboBoxBusqueda.Items.Add(aux.Nombre);
                }
            }
            if (articulosBuscados.Count != 0) {

            cboBoxBusqueda.Text = "Seleccione el item";
            }
            articulos = articulosBuscados;
         
        }
        //articulo encontrado
        private void cboSeleccionado(object sender, EventArgs e)
        {

            seleccionLista = cboBoxBusqueda.SelectedIndex;
            TXTCodigo.Text = articulos[cboBoxBusqueda.SelectedIndex].Codigo;
            TXTBDescripcion.Text= articulos[cboBoxBusqueda.SelectedIndex].Descripcion;
            CboMarca.Text=articulos[cboBoxBusqueda.SelectedIndex].Marca;
            CboCategoria.Text=articulos[cboBoxBusqueda.SelectedIndex].Categoria;
            TxtPrecio.Text = articulos[cboBoxBusqueda.SelectedIndex].Precio.ToString();
            TxtURL.Text= articulos[cboBoxBusqueda.SelectedIndex].Imagen.ToString();
            ArticuloModificar.IDCategoria = articulos[cboBoxBusqueda.SelectedIndex].IDCategoria;
            ArticuloModificar.id = articulos[cboBoxBusqueda.SelectedIndex].id;
            ArticuloModificar.IDMarca = articulos[cboBoxBusqueda.SelectedIndex].IDMarca;

           
            Marca = conexionART.Marca();
            for (int i = 0; i < Marca.Count; i++)
            {
               
                CboMarca.Items.Add(Marca[i].Marca.ToString());
               
            }
            Categoria = conexionART.Categoria();

            for (int i = 0; i < Categoria.Count; i++)
            {
                
                CboCategoria.Items.Add(Categoria[i].Descripcion.ToString());
                
            }
                        
        }


        private void SeleccionMarca(object sender, EventArgs e)
        {
            ArticuloModificar.IDMarca =Marca[CboMarca.SelectedIndex].IDMarca;
           
        }

        private void SeleccionCategoria(object sender, EventArgs e)
        {
         
            ArticuloModificar.IDCategoria = Categoria[CboCategoria.SelectedIndex].IDCategoria;
        }


        private void BTNModificar_Click(object sender, EventArgs e)
        {
            if (validarCamposTxt()){

                EliminarIconosErrorProv();

                ArticuloModificar.Nombre = cboBoxBusqueda.Text;
                ArticuloModificar.Codigo = TXTCodigo.Text;
                ArticuloModificar.Descripcion = TXTBDescripcion.Text;
                ArticuloModificar.Precio = SqlMoney.Parse(TxtPrecio.Text);
                ArticuloModificar.Imagen = TxtURL.Text;

                 MessageBox.Show("SE MODIFICO CON EXITO");
                Controller conexionART = new Controller();
                conexionART.Modificar(ArticuloModificar);


            }
            else
            {
                MessageBox.Show("NO SE MODIFICO EL ARTICULO.");
            }
           
            
        }

    }
    
}
