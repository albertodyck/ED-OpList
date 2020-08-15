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

        public void AgregarNodoInicio(string dato)
        {
            nodoActual = nodoInicial;

            Nodo nodoNuevo = new Nodo();
            nodoNuevo.Dato = dato;
            nodoNuevo.Enlace = nodoActual.Enlace;

            nodoActual.Enlace = nodoNuevo;
        }

        public Nodo Buscar(string dato)
        {
            //validamos que no este vacio
            if (ValidaVacia())
            {
                return null;
            }

            Nodo nodoBusqueda = nodoInicial;

            while (nodoBusqueda.Enlace !=null)
            {
                nodoBusqueda = nodoBusqueda.Enlace;
                //situados en el siguiente
                if (nodoBusqueda.Dato==dato)
                {
                    return nodoBusqueda;
                }
            }

            return null;
        }

        public Nodo BuscarIndice(int indice)
        {
            int Indice = -1;

            if (ValidaVacia())
            {
                return null;
            }

            nodoActual = nodoInicial;

            while (nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
                Indice++;

                if (Indice == indice)
                {
                    return nodoActual;
                }
            }

            return null;
        }

        public Nodo BuscarAnterior(string dato)
        {
            if (ValidaVacia())
            {
                return null;
            }

            Nodo nodoBusqueda = nodoInicial;
            while (nodoBusqueda.Enlace !=null && nodoBusqueda.Enlace.Dato != dato)
            {
                nodoBusqueda = nodoBusqueda.Enlace;
                if (nodoBusqueda.Enlace.Dato == dato)
                {
                    return nodoBusqueda;
                }
            }
            return null;
        }

        public void BorrarNodo(string dato)
        {
            if (!ValidaVacia())
            {
                nodoActual = Buscar(dato);

                if (nodoActual!=null)
                {
                    Nodo nodoAnterior = BuscarAnterior(dato);
                    nodoAnterior.Enlace = nodoActual.Enlace;

                    //Otra manera de asignar el valor
                    //BuscarAnterior(dato).Enlace = nodoActual.Enlace;

                    nodoActual.Enlace = null;

                }
            }
        }

    }
}
