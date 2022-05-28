using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD.Model
{
    public class Cola
    {
        private Nodo Inicio { get; set; }

        public void Enqueue(Factura factura)
        {
            AgregarAlComienzo(factura);
        }
        private void AgregarAlComienzo(Factura factura)  //Cargar de atras para adelante
        {
            Nodo nodoFactura = new Nodo();      //Creo un nodo que contiene la factura
            nodoFactura.Factura = factura;

            nodoFactura.Siguiente = Inicio;     //Lo movemos a la posicion 2
            Inicio = nodoFactura;               //Y en inicio aparece el nuevo dato
        }

        //_________________________________________________________________________________________\\ -> Separador
        public Factura Dequeue()
        {
            if (!IsEmpty())   // Si no esta vacia.
            {
                return EliminarAlFinal();
            }

            return null;     // Si esta vacia no elimina nada

        }

        private Factura EliminarAlFinal()
        {
            Nodo nodoAux = Inicio;

            nodoAux = BuscarAnteUltimoNodo(nodoAux);

            if (nodoAux == null) //La lista esta vacia
                return null;
            else if (nodoAux.Siguiente == null)//Si tengo un solo dato en la lista
            {
                Factura aux = Inicio.Factura; //Guardo el dato
                Inicio = null;
                return aux;
            }
            else
            {
                Factura aux = nodoAux.Siguiente.Factura;
                nodoAux.Siguiente = null;
                return aux;
            }
        }

        private Nodo BuscarAnteUltimoNodo(Nodo nodoInicial)
        {

            if (nodoInicial == null || nodoInicial.Siguiente == null || nodoInicial.Siguiente.Siguiente == null) return nodoInicial;

            return BuscarAnteUltimoNodo(nodoInicial.Siguiente);
        }
        public bool IsEmpty()   //Lista esta vacia?
        {
            return Inicio == null;
        }
        //_________________________________________________________________________________________\\ -> Separador
        public int PeekAlFinal()
        {
            Nodo nodoAux = Inicio;
            nodoAux = BuscarUltimoNodo(nodoAux);
            int codigoo = nodoAux.Factura.codigo;


            return codigoo;
        }
        private Nodo BuscarUltimoNodo(Nodo nodoInicial)
        {

            if (nodoInicial == null || nodoInicial.Siguiente == null) return nodoInicial;

            return BuscarUltimoNodo(nodoInicial.Siguiente);
        }

        //_________________________________________________________________________________________\\ -> Separador

        public Factura BuscarFactura(int nroCodigo)
        {
            Nodo nodoAux = Inicio;
            nodoAux = BuscarFacturaEnLista(nodoAux, nroCodigo);

            if (nodoAux != null)
            {
                return nodoAux.Factura;
            }
            return null;
        }

        private Nodo BuscarFacturaEnLista(Nodo nodoInicial, int nroCodigo)
        {
            if (nodoInicial == null || nodoInicial.Factura.codigo == nroCodigo)
            {
                return nodoInicial;
            }
            return BuscarFacturaEnLista(nodoInicial.Siguiente,nroCodigo);
        }
    }
}
    

