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
    }
}
