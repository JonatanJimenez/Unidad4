using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_3JimenezAhumadaJonatanAlberto
{
    class Program
    {
        static void Main(string[] args)
        {
            var vertices = new[] { "A", "B", "C", "G", "F", "D", "E" };// se crea una variable vertices al cual le damos de valor un arreglo de letras
            
            var aristasCamino1 = new[]// se crea un nuevo arreglo llamado aristasCamino1 al cual le damos de valor lo que se crea al momento de usar Tuple
            {
                Tuple.Create("A","B"), Tuple.Create("B","G"), Tuple.Create("C","B"),// se usa Tuple para crear tuplas en este caso de 2 
                Tuple.Create("D","C"), Tuple.Create("C","G"), Tuple.Create("D","F"),
                Tuple.Create("D","E"), Tuple.Create("F","E")
            };

            var aristasCamino2 = new[]// // se crea un nuevo arreglo llamado aristasCamino2 al cual le damos de valor lo que se crea al momento de usar Tuple
            {
                Tuple.Create("A","B"), Tuple.Create("B","C"),Tuple.Create("G","B"),// se usa Tuple para crear tuplas en este caso de 2 
                Tuple.Create("F","G"), Tuple.Create("C","G"),Tuple.Create("D","F"),
                Tuple.Create("D","E"), Tuple.Create("F","E")
            };

            var grafo1 = new Grafo<string>(vertices, aristasCamino1);// creamos una variable grafo1 en el cual inicializamos una instancia de la clase Grafo
            var grafo2 = new Grafo<string>(vertices, aristasCamino2);// creamos una variable grafo2 en el cual inicializamos una instancia de la clase Grafo
            var algoritmos = new Algoritmo();// se crear una variable llamada algoritmos en la cual se inicializa una nueva instancia de la clase Algoritmo
            
            var empezarVertice = "A";// le damos el valor a la variable empezarVertice de un string, en este caso A 
            var caminoMasCorto = algoritmos.RutaCorta(grafo1, empezarVertice);// variable caminoMasCorto al cual le damos el valor de la ruta corta generada por 
                                                                              // el metodo RutaCorta de la clase Algoritmo 
            foreach (var vertice in vertices)// por cada variable en vertices 
                Console.WriteLine("Camino mas corto a \"{0}\": {1} ",vertice, string.Join(" --> ", caminoMasCorto(vertice)));// se imprime el camino mas corto 
                                                                                                                             // generado para cada variable de vertices 
            Console.WriteLine();// salto de renglon 
            Console.WriteLine("Trayectoria Simple 1: {0}",string.Join(" --> ", algoritmos.BusquedaAmplitud(grafo1, "A")));// Imprime la primera trayectoria simple 
            Console.WriteLine("Trayectoria Simple 2: {0}",string.Join(" --> ", algoritmos.BusquedaAmplitud(grafo2, "A")));// Imprime la segunda trayectoria simple 
        }
    }
}
