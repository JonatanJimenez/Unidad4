using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4JimenezAhumadaJonatanAlberto
{
    class Grafo
    {
        public int vertice { get; set; } 
        List<int>[] Lista;
        
        public Grafo(int valor) 
        {
            vertice = valor;
            Lista = new List<int>[valor]; 

            for (int i = 0; i < valor; i++) 
            {
                Lista[i] = new List<int>();
            }
        }

        public void AgregarValorlista(int indice, int valor) 
        {
            Lista[indice].Add(valor); 
        }

        public void Camino(int valor, int dato)
        {
            List<string> ciudad = new List<string>();
            if (dato == 1 || dato == 2)
            {
                ciudad.Add("Boston");
                ciudad.Add("Chicago");
                ciudad.Add("Denver");
                ciudad.Add("LA");
                ciudad.Add("New York");
                ciudad.Add("San Francisco");
                ciudad.Add("Miami");
                ciudad.Add("Atlanta");
            }
            if (dato == 3)
            {
                ciudad.Add("Atlanta");
                ciudad.Add("Chicago");
                ciudad.Add("San Francisco");
                ciudad.Add("Boston");
                ciudad.Add("Denver");
                ciudad.Add("LA");
                ciudad.Add("New York");
                ciudad.Add("Miami");
            }
            if (dato == 4)
            {
                ciudad.Add("Denver");
                ciudad.Add("Chicago");
                ciudad.Add("New York");
                ciudad.Add("Atlanta");
                ciudad.Add("San Francisco");
                ciudad.Add("Boston");
                ciudad.Add("LA");
                ciudad.Add("Miami");
            }

            bool[] visita = new bool[vertice];

            Stack<int> Pila = new Stack<int>();

            visita[valor] = true;
            Pila.Push(valor);            
            while (Pila.Count != 0)
            {
                valor = Pila.Pop();
                Console.Write("{0} -> ", ciudad[valor]);
                foreach (int item in Lista[valor])
                {
                    if (!visita[item])
                    {
                        visita[item] = true;
                        Pila.Push(item);
                    }
                }                
            }

            Console.Write("Ha llegado a su destino");
        }
    }
}
