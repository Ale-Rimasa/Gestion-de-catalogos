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
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Drawing.Imaging;
using System.Security.Policy;

namespace Catalogo
{

    

    public partial class FMRArticulo : Form
    {
        public Articulo artiNuevo = new Articulo();
        List <Articulo> ListaMarca= new List <Articulo>();
        List <Articulo> ListaCategoria= new List<Articulo> ();
        AccesoDatos accesoDatos = new AccesoDatos();
        AccesoDatos accesoDatos2 = new AccesoDatos();
        public FMRArticulo()
        {
            InitializeComponent();
        }
        bool StringNoVacio(string a)
        {
            if (a == "")
            {
                return false;
            }
            else { return true; }

        }
        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validarCamposTxt()
        {
            EliminarIconosErrorProv();
            bool ok = true;

            if (!StringNoVacio(TXTBID.Text)) ErrorProvCargaArticulo.SetError(TXTBID, "Ingrese el Codigo.");
            if (!StringNoVacio(TXTBNombre.Text)) ErrorProvCargaArticulo.SetError(TXTBNombre, "Ingrese el Nombre.");
            if (!StringNoVacio(TXTBDescripcion.Text)) ErrorProvCargaArticulo.SetError(TXTBDescripcion, "Ingrese la Descripcion.");

            if (cboMarca.SelectedIndex < 0)
            {
               
                ok = false;
                ErrorProvCargaArticulo.SetError(cboMarca, "Seleccione la Marca.");
            }
            if (cboCategoria.SelectedIndex < 0)
            {
                ok = false;
                ErrorProvCargaArticulo.SetError(cboCategoria, "Seleccione la Categoria.");
            }
            float numero;
            if (!float.TryParse(TXTBPrecio.Text, out numero) || numero<0)
            {
                
                ErrorProvCargaArticulo.SetError(TXTBPrecio, "Ingrese valor numerico positivo. ");
                TXTBPrecio.Clear();
                ok = false;
            }

            if (txtbUrlImagen.Text == "" || txtbUrlImagen.Text.Length>999)
            {
                ok = false;
                ErrorProvCargaArticulo.SetError(txtbUrlImagen, "Ingrese la Url y no puede exceder los 999 caracteres ");
            }
            return ok;
        }
        private void EliminarIconosErrorProv()
        {
            ErrorProvCargaArticulo.SetError(TXTBID, "");
            ErrorProvCargaArticulo.SetError(TXTBNombre, "");
            ErrorProvCargaArticulo.SetError(TXTBDescripcion, "");
            ErrorProvCargaArticulo.SetError(cboMarca, "");
            ErrorProvCargaArticulo.SetError(cboCategoria, "");
            ErrorProvCargaArticulo.SetError(TXTBPrecio, "");
            ErrorProvCargaArticulo.SetError(txtbUrlImagen, "");
           
        }
        private void BTNAdd_Click_1(object sender, EventArgs e)
            {
                if (validarCamposTxt())
                {

                  Controller conexion = new Controller();
                  try
                  {

                    EliminarIconosErrorProv();
                
                      MessageBox.Show("Datos Ingresados Correctamente.");
                
                      validarCamposTxt();

                      artiNuevo.Codigo = TXTBID.Text;
                      artiNuevo.Nombre = TXTBNombre.Text;
                      artiNuevo.Descripcion = TXTBDescripcion.Text;
                      artiNuevo.Precio = SqlMoney.Parse(TXTBPrecio.Text);


                      string url = txtbUrlImagen.Text;
            

                      conexion.Agregar(artiNuevo);
                      MessageBox.Show("Articulo agregado");
                      Close();
                  }
              
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.ToString());
                  }
                }

        }
        private void FMRArticulo_Load_1(object sender, EventArgs e)
        {
            

            try
            {

                accesoDatos.setearQuery("select id, Descripcion From Marcas");
                accesoDatos.ejecutarLectura();


                while (accesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IDMarca = accesoDatos.Lector.GetInt32(0);
                    ListaMarca.Add(aux);
                    cboMarca.Items.Add((string)accesoDatos.Lector["Descripcion"]);

                }

                accesoDatos2.setearQuery("select id, Descripcion From CATEGORIAS");
                accesoDatos2.ejecutarLectura();

                while (accesoDatos2.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IDCategoria = accesoDatos2.Lector.GetInt32(0);
                    ListaCategoria.Add(aux);
                   
                    cboCategoria.Items.Add((string)accesoDatos2.Lector["Descripcion"]);

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                accesoDatos.cerrarConexion();
                accesoDatos2.cerrarConexion();
            }
        }
        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            artiNuevo.IDMarca =ListaMarca[cboMarca.SelectedIndex].IDMarca;
            
           

        }
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            artiNuevo.IDCategoria = ListaCategoria[cboCategoria.SelectedIndex].IDCategoria;
           
        }

       
    }
}
