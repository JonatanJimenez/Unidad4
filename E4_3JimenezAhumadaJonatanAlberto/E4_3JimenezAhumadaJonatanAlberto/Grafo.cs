using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_3JimenezAhumadaJonatanAlberto
{
    class Grafo<T>// se crea la clase Grafo
    {
        public Grafo() { }// Constructor

        public Dictionary<T, HashSet<T>> ListaAdyacencia { get; } = new Dictionary<T, HashSet<T>>();// se crea una coleccion de la clase Dictionary 
        // en la cual pide dos parametros, los cuales son T, que representa el TKey y HashSet que representa TValue

        public void AgregarVertice(T vertice)//Metodo de tipo void llamado AgregarVertice al cual le mandamos como parametro un vertice 
        {
            ListaAdyacencia[vertice] = new HashSet<T>();// se usa la colecccion llamada ListaAdyacencia a la cual le damos de parametro vertice
                                                        // y se iguala a un nuevo HashSet
        }

        public void AgregarArista(Tuple<T, T> arista)//Metodo void llamado AgregarArista en la cual pedimos de paratro una arista 
        {
            if (ListaAdyacencia.ContainsKey(arista.Item1) && ListaAdyacencia.ContainsKey(arista.Item2))// se emplea un if en el cual se usa el metodo 
                                                                                                        //ListaAdyacencia 
            {
                //Si se cumple el if 
                ListaAdyacencia[arista.Item1].Add(arista.Item2);// se le agrega al metodo ListaAdyacencia en arista.item1 la arista.Item2
                ListaAdyacencia[arista.Item2].Add(arista.Item1);// se le agrega al metodo ListaAdyacencia en arista.item2 la arista.Item1
            }
        }
        public Grafo(IEnumerable<T> vertices, IEnumerable<Tuple<T, T>> aristas)// Constructor sobrecargado, en el cual pedimos 2 parametros 
                                                                               // vertices y aristas de tipo IEnumerable                 
        {
            foreach (var vertice in vertices)// foreach en el cual por cada vertice en vertices 
                AgregarVertice(vertice); // apoyandonos del metodo AgregarVertice, agregamos un vertice 

            foreach (var arista in aristas)// foreach en el cual por cada arista en aristas 
                AgregarArista(arista);//// apoyandonos del metodo AgregarArista, agregamos una arista
        }               
    }
}
