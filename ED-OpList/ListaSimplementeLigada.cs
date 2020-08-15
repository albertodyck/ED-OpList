using System;
using System.Collections.Generic;
using System.Text;

namespace ED_OpList
{
    public class ListaSimplementeLigada
    {
        private Nodo nodoInicial;//No se utiliza solo marca el inicio
        private Nodo nodoActual;

        public ListaSimplementeLigada()
        {
            nodoInicial = new Nodo();
            nodoInicial.Enlace = null;//Nodo inicial no esta enlazado a nada
        }

        public string RecorrerLista()
        {
            string datos = string.Empty;

            nodoActual = nodoInicial;
            //mientras nodo actual sea diferente de nulo, nulo es llegar al final de la lista
            while(nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
                datos += $"{nodoActual.Dato}\n";
            }
            return datos;
        }

        public void VaciarLista()
        {
            //Con solo eliminar el primer enlace se rompe la lista 
            //y solo con el garbage collector se lleva todo de la memoria
            nodoInicial.Enlace = null;
        }

        public bool ValidaVacia()
        {
            return (nodoInicial.Enlace==null);
        }

        public void AgregarNodo(string dato)
        {
            nodoActual = nodoInicial;

            while (nodoActual.Enlace!=null)
            {
                nodoActual = nodoActual.Enlace;
            }

            //salimos cuando encontramos el ultimo nodo con propiedad nulo
            //creamos el nodo nuevo en esa posicion
            Nodo nodoNuevo = new Nodo();
            //grabamos dato en la propiedad del nodo nuevo
            nodoNuevo.Dato = dato;
            //establecemos su propiedad enlace en nulo al ser el ultimo enlace
            nodoNuevo.Enlace = null;
            //en nodo actual cuyo enlace era nulo ahora apuntara al nuevo nodo
            nodoActual.Enlace = nodoNuevo;
        }



    }
}
