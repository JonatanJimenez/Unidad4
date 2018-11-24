using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_4JimenezAhumadaJonatanAlberto
{
    class Menu
    {
        public void MenuPrincipal()
        {
            ImprimirArbol arboles = new ImprimirArbol();

            arboles.ImprimirArbolGenerico();
            arboles.ImprimirArbolBinario();

            Console.ReadKey();
            Console.Clear();

            ImprimirRuta rutas = new ImprimirRuta();

            rutas.ImprimirRutas();
            Console.ReadKey();
        }
    }
}
