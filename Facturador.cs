using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaDeFactoracion
{
    public class Facturador
    {
        List<Producto> listaProductos = new List<Producto>();

        public void añadirProducto( Producto newProducto ){
            listaProductos.Add(newProducto);
        }

        public List<Producto> obtenerProductos() {
            return listaProductos;
        }
    }
}
