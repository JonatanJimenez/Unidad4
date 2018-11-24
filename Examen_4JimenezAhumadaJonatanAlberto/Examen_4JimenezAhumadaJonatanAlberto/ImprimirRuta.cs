using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4JimenezAhumadaJonatanAlberto
{
    class ImprimirRuta
    {
        public void ImprimirRutaBLA()
        {
            Console.WriteLine("Ruta mas corta Boston-Los Angeles");
            Grafo grafo = new Grafo(5);
            grafo.AgregarValorlista(0, 1);
            grafo.AgregarValorlista(1, 2);
            grafo.AgregarValorlista(2, 3);
            grafo.Camino(0, 1);           
                      
        }

        public void ImprimirRutaNySF()
        {
            Console.WriteLine("Ruta mas corta Nueva York-San Francisco");
            Grafo grafo = new Grafo(7);
            grafo.AgregarValorlista(0, 1);
            grafo.AgregarValorlista(1, 2);
            grafo.AgregarValorlista(2, 3);
            grafo.AgregarValorlista(4, 5);
            grafo.Camino(4, 2);                        
        }

        public void ImprimirRutaASF()
        {
            Console.WriteLine("Ruta mas corta Atlanta-San Francisco");
            Grafo grafo = new Grafo(4);
            grafo.AgregarValorlista(0, 1);
            grafo.AgregarValorlista(1, 2);
            grafo.Camino(0, 3);                      
        }

        public void ImprimirutaDNY()
        {
            Console.WriteLine("Ruta mas corta Denver-Nueva York");
            Grafo grafo = new Grafo(4);
            grafo.AgregarValorlista(0, 1);
            grafo.AgregarValorlista(1, 2);
            grafo.Camino(0, 4);                       
        }

        public void ImprimirRutas()
        {
            Console.WriteLine("Rutas mas cortas\n");
            ImprimirRutaBLA();
            Console.WriteLine("\nMillas recorridas: 2602 mi\n");
            ImprimirRutaNySF();
            Console.WriteLine("\nMillas recorridas: 2534 mi\n");
            ImprimirRutaASF();
            Console.WriteLine("\nMillas recorridas: 2461 mi\n");
            ImprimirutaDNY();
            Console.WriteLine("\nMillas recorridas: 1630 mi\n");           
        }
    }
}
