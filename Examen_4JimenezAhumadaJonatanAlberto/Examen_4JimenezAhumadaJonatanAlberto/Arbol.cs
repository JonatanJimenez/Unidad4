using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4JimenezAhumadaJonatanAlberto
{
    class Arbol
    {
        public Nodo raiz;

        public Arbol()
        {
            raiz = null;
        }
                        
        public void Preorden(Nodo nodo)
        {  
            if (nodo == null)
                return;
            
            Console.Write(nodo.llave + " ");            
            Preorden(nodo.izquierda);
            Preorden(nodo.medio);
            Preorden(nodo.derecha);
        }

        public void Postorden(Nodo nodo)
        {
            if (nodo == null)
                return;

            Postorden(nodo.izquierda);
            Postorden(nodo.medio);
            Postorden(nodo.derecha);
            Console.Write(nodo.llave + " ");
        }

        public void ImprimirPostorden()
        {
            Postorden(raiz);
        }
        public void ImprimirPreorden()
        {
            Preorden(raiz);
        }
    }
}

