using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

       
namespace Catalogo
{
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
           Form CargaArticul= new Form();
            CargaArticul.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          FMRArticulo ventana= new FMRArticulo();
            ventana.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMRBusqueda ventanaBusquedad = new FMRBusqueda();
            ventanaBusquedad.ShowDialog();
       }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Catalago v1.0 creado por Daniel Guillen, Alejandro Rimasa y Federico Mojica");}

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMRModificar modificarART= new FMRModificar();
            modificarART.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMRListadeArticulo listadeArticulo= new FMRListadeArticulo();
            listadeArticulo.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AGREGAR_MARCA_CATEGORIA MC=new AGREGAR_MARCA_CATEGORIA();
            MC.ShowDialog();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FMR_Eliminar_MC MC_eliminar = new FMR_Eliminar_MC();
            MC_eliminar.ShowDialog();
        }
    }
}
