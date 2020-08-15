using System;

namespace ED_OpList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaSimplementeLigada lista = new ListaSimplementeLigada();
            Console.WriteLine(lista.RecorrerLista());

            
            lista.AgregarNodo("uno");
            lista.AgregarNodo("dos");
            lista.AgregarNodo("tres");
            Console.WriteLine(lista.RecorrerLista());
            Console.WriteLine("Agregando al inicio");
            lista.AgregarNodoInicio("cero");
            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Buscando dos");
            Nodo nodo = lista.Buscar("dos");
            if (nodo==null)
            {
                Console.WriteLine("No se encontro");
            }
            else
            {
                Console.WriteLine($"Se encontro {nodo.Dato}");
            }
        }
    }
}
