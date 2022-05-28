using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD.Model
{
    internal class Nodo
    {
        public Factura Factura { get; set; }    //Dato de mi nodo
        public Nodo Siguiente { get; set; }    //Puntero
    }
}
