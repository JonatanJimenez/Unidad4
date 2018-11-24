using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4JimenezAhumadaJonatanAlberto
{
    class Nodo
    {
        public string llave;
        public Nodo izquierda, derecha, medio;

        public Nodo(string objeto)
        {
            llave = objeto;
            izquierda = null;
            derecha = null;
        }
    }
}
