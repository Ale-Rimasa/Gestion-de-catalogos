using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public int IDMarca { get; set; }
        public string Marca { get; set; }   
        public int IDCategoria { get; set; }
        public string Categoria { get; set; }
        public SqlMoney Precio { get; set; }
        public string Imagen { get; set; }

        public void Cargar()
        {

        }
    }   
}
