using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ClientesBL
    {
        public List<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new List<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Choloma");
            var ciudad2 = new Ciudad(2, "San Pedro Sula");

            var cliente1 = new Cliente(1, "Juan", "87485789", ciudad1, ciudad1.Descripcion);
            var cliente2 = new Cliente(2, "Sara", "87485789", ciudad2, ciudad2.Descripcion);
            var cliente3 = new Cliente(3, "Veronica", "87485789", ciudad2, ciudad2.Descripcion);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
            ListadeClientes.Add(cliente3);
        }
    }
}
