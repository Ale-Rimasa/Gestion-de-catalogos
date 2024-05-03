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

namespace Catalogo
{
    public partial class AGREGAR_MARCA_CATEGORIA : Form
    {
        public AGREGAR_MARCA_CATEGORIA()
        {
            InitializeComponent();

        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            Controller B_marcas= new Controller();
            Controller B_Categorias = new Controller();
           
            if (RD_marca.Checked && TB_ingresar_MC.Text!="")
            {
                bool a = true;
                for (int i = 0; i < B_marcas.Marca().Count; i++)
                {
                    if (B_marcas.Marca()[i].Marca.ToString().ToLower().Equals(TB_ingresar_MC.Text.ToLower()))
                    {
                   
                        a = false;
                    }
                   
                }
                if (a)
                {
                    Controller Conect = new Controller();
                    Conect.AgregarMarca(TB_ingresar_MC.Text);
                    MessageBox.Show("SE AGREGO CON EXITO");
                }
                else { MessageBox.Show("MARCA REGISTRADA");}

            }

            if (RD_Categoria.Checked && TB_ingresar_MC.Text != "")
            {
                bool a = true;
                for (int i = 0; i < B_Categorias.Categoria().Count; i++)
                {
                    if (B_Categorias.Categoria()[i].Descripcion.ToString().ToLower().Equals(TB_ingresar_MC.Text.ToLower()))
                    {

                        a = false;
                    }

                }
                if (a)
                {
                    Controller Conect = new Controller();
                    Conect.AgregarCategoria(TB_ingresar_MC.Text);
                    MessageBox.Show("SE AGREGO CON EXITO");
                }
                else { MessageBox.Show("CATEGORIA YA REGISTRADA"); }


            }

          
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
