using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acciones;
using Dominio;
namespace Catalogo
{
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        AccesoDatos BD_Eliminar=new AccesoDatos();
        Controller BD_Buscar =new Controller();
        List<Articulo> list = new List<Articulo>();
        

        //lo que seleccionamos en el list lo mostramos en el laber
        private void listSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSeleccion.SelectedIndex >= 0)
            {

                listSeleccion.Text = (string)listSeleccion.Items[listSeleccion.SelectedIndex];
                lblSeleccionado.Text = "Su seleccion de articulo fue: " + listSeleccion.Text;

            }
        }

       private bool ValidarEntadaTxt(string PalabraClave)
        {
            if(string.IsNullOrWhiteSpace(PalabraClave))
            {
                MessageBox.Show("Por favor ingrese una letra o palabra clave para continuar");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listSeleccion.Items.Clear(); 
            if (!ValidarEntadaTxt(txtEliminar.Text))
            {
                return;
            }

            list = BD_Buscar.Busquedad(txtEliminar.Text);
            if (list.Count == 0)
            {
                MessageBox.Show("Su articulo no se encuentra.");
                lblSeleccionado.Text = "";
                return;
            }

            foreach (Articulo l in list) {
                listSeleccion.Items.Add(l.Codigo+"  "+l.Nombre +"  "+ l.Marca);
                lblSeleccionado.Text = "Seleccione su Articulo";
                
            }
        }


        private bool ValidoSeleccion()
        {
            if(listSeleccion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccion el elemento a eliminar");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidoSeleccion())
            {
                return;
            }

            BD_Eliminar.setearQuery("delete from IMAGENES where IMAGENES.IdArticulo=(select id from ARTICULOS where ARTICULOS.Codigo='" + list[listSeleccion.SelectedIndex].Codigo+ "') delete from ARTICULOS where Codigo='"+ list[listSeleccion.SelectedIndex].Codigo+"';");
            BD_Eliminar.ejecutarAccion();
            BD_Eliminar.cerrarConexion();
            
            lblSeleccionado.Text = "";
            MessageBox.Show("Se Elimino Exitosamente el elemento: " + list[listSeleccion.SelectedIndex].Codigo);

            listSeleccion.Items.Clear();
            
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
