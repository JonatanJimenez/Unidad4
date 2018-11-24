using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4JimenezAhumadaJonatanAlberto
{
    class ImprimirArbol
    {
        public void ImprimirArbolGenerico()
        {
            Console.WriteLine("Arbol #1 Generico\n");

            Arbol arbolBinario = new Arbol();

            arbolBinario.raiz = new Nodo("A");
            arbolBinario.raiz.izquierda = new Nodo("B");
            arbolBinario.raiz.derecha = new Nodo("E");
            arbolBinario.raiz.izquierda.izquierda = new Nodo("C");
            arbolBinario.raiz.izquierda.derecha = new Nodo("D");
            arbolBinario.raiz.derecha.derecha = new Nodo("F");
            arbolBinario.raiz.derecha.derecha.izquierda = new Nodo("G");
            arbolBinario.raiz.derecha.derecha.derecha = new Nodo("H");

            Console.WriteLine("Recorrido Preorden");
            arbolBinario.ImprimirPreorden();           
            Console.WriteLine("\nRecorrido Postorden");
            arbolBinario.ImprimirPostorden();            
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }

        public void ImprimirArbolBinario()
        {
            Console.WriteLine("Arbol #2 Binario\n");

            Arbol arbolGenerico = new Arbol();

            arbolGenerico.raiz = new Nodo("A");
            arbolGenerico.raiz.izquierda = new Nodo("B");
            arbolGenerico.raiz.medio = new Nodo("C");
            arbolGenerico.raiz.derecha = new Nodo("D");
            arbolGenerico.raiz.izquierda.izquierda = new Nodo("E");
            arbolGenerico.raiz.izquierda.medio = new Nodo("F");
            arbolGenerico.raiz.izquierda.derecha = new Nodo("G");
            arbolGenerico.raiz.derecha.izquierda = new Nodo("H");
            arbolGenerico.raiz.derecha.medio = new Nodo("I");
            arbolGenerico.raiz.derecha.derecha = new Nodo("J");
            arbolGenerico.raiz.izquierda.izquierda.izquierda = new Nodo("K");
            arbolGenerico.raiz.izquierda.izquierda.medio = new Nodo("L");
            arbolGenerico.raiz.izquierda.izquierda.derecha = new Nodo("M");
            arbolGenerico.raiz.izquierda.derecha.medio = new Nodo("N");
            arbolGenerico.raiz.derecha.izquierda.medio = new Nodo("O");
            arbolGenerico.raiz.derecha.derecha.izquierda = new Nodo("P");
            arbolGenerico.raiz.derecha.derecha.derecha = new Nodo("Q");
            arbolGenerico.raiz.izquierda.derecha.medio.izquierda = new Nodo("R");
            arbolGenerico.raiz.izquierda.derecha.medio.derecha = new Nodo("S");
           
            Console.WriteLine("Recorrido Preorden");            
            arbolGenerico.ImprimirPreorden();           
            Console.WriteLine("\nRecorrido Postorden");
            arbolGenerico.ImprimirPostorden();
            Console.WriteLine();          
        }

        public void MenuArbol()
        {
            
        }
    }
}
