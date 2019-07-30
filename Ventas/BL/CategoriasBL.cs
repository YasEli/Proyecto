using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class CategoriasBL
    {
        public List<Categoria> ListadeCategoria { get; set; }

        public CategoriasBL()
        {
            ListadeCategoria = new List<Categoria>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var cateogoria1 = new Categoria(1, "Laptops");
            var categoria2 = new Categoria(2, "Accesorios");

            ListadeCategoria.Add(cateogoria1);
            ListadeCategoria.Add(categoria2);
        }
    }
}
