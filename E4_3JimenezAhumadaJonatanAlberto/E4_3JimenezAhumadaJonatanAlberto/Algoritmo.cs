using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_3JimenezAhumadaJonatanAlberto
{
    class Algoritmo// se crea la clase algoritmo 
    {
        public Func<T, IEnumerable<T>> RutaCorta<T>(Grafo<T> grafo, T empezar)// Metodo llamado RutaCorta
        {
            var anterior = new Dictionary<T, T>();// variable llamada anterior en la cual se inicializa una nueva instancia de la clase Dictionary

            var cola = new Queue<T>();// se crea una variable llamada cola en la cual se inicializa una nueva instancia de la clase Queue 
            cola.Enqueue(empezar);// se le añade a la cola el parametro que pedimos llamado empezar 

            while (cola.Count > 0)// Mientras que el numero de elementos de la cola sea mayor a 0 
            {
                var vertice = cola.Dequeue();// se crea una nueva variable llamada vertice en la cual se quita el valor de la cola 
                foreach (var vecino in grafo.ListaAdyacencia[vertice])// por cada variable en el metodo ListaAdyacencia[vertice]
                {
                    if (anterior.ContainsKey(vecino))//si anterior contiene vecino 
                        continue;// continua

                    anterior[vecino] = vertice;// anterior en vecino se le da el valor de vertice 
                    cola.Enqueue(vecino);// se añade a la cola vecino 
                }
            }

            Func<T, IEnumerable<T>> TrayectoriaMasCorta = v =>// Metodo llamado TrayectoriaMasCorta
            {
                var camino = new List<T> { };// se crea una variable llamada camino en la cual se nicializa una nueva instancia de la clase List 

                var presente = v;// se le da el valor a la variable presente de v 
                while (!presente.Equals(empezar))// mientras sea diferente de presente.equals(empezar) 
                {
                    camino.Add(presente);// se agrega a camino (que es una lista) presente 
                    presente = anterior[presente];// se le da el valor de presente de anterior[presente]
                };

                camino.Add(empezar);// se le agrega a la lista empezar 
                camino.Reverse();//  se invierte el orden de la lista 
                return camino;// regresa camino 
            };

            return TrayectoriaMasCorta;// regresa trayectoriaMasCorta 
        }

        public HashSet<T> BusquedaAmplitud<T>(Grafo<T> grafo, T empezar)//Metodo llamado BusquedaAmplitud 
        {
            var visitado = new HashSet<T>();// se crea una variable llamada visitado en la cual se inicializa una nueva instancia de la clase HashSet

            if (!grafo.ListaAdyacencia.ContainsKey(empezar))// si es distinto de grafo.ListaAdyacencia.ContainsKey(empezar)  
                return visitado;//regresa visitado 

            var cola = new Queue<T>();// se crea una variable llamada cola en la cual se inicializa una nueva instancia de la clase Queue
            cola.Enqueue(empezar);// se le agrega empezar a la cola 

            while (cola.Count > 0)//mientras que el numero de elementos en la cola sea mayor a 0 
            {
                var vertice = cola.Dequeue();// se crea una variable vertice a la cual se le da el valor de lo que habia en la cola 

                if (visitado.Contains(vertice))// si visitado contiene el valor de vertice 
                    continue;//continua 

                visitado.Add(vertice);// se le agrega a visitado el vertice 

                foreach (var vecino in grafo.ListaAdyacencia[vertice])// por cada var en la ListaAdyacencia del grafo 
                    if (!visitado.Contains(vecino))// si es disitinto de visitado.Contains(vecino)
                        cola.Enqueue(vecino);// se le agrega a la cola vecino 
            }
            return visitado;//regresa visitado 
        }                
    }
}
