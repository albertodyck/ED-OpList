namespace ED_OpList
{
    public class Nodo
    {
        private string dato;
        private Nodo enlace;

        //ctrl + . para genarar la propiedad
        //Las funciones de flecha ahorran codigo, metodos anonymos, funciones que se llaman que no tienen nombre
        public string Dato { get => dato; set => dato = value; }
        public Nodo Enlace { get => enlace; set => enlace = value; }

        public Nodo()
        {
            enlace = null;//ultimo nodo no tiene enlace a nada
        }
    }


}
