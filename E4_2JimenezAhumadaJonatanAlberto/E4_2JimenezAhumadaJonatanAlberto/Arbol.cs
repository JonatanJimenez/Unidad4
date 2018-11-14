using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_2JimenezAhumadaJonatanAlberto
{
    class Arbol
    {
        private Nodo raiz;// Variable de tipo Nodo
        private Nodo trabajo;//Variable de tipo Nodo
        private int i = 0, altura;//variables de tipo entero para su posterior utilizacion 

        public Arbol()//Constructor de la clase Arbol 
        {
            raiz = new Nodo();//se crea un nuevo nodo 
        }

        public Nodo Insertar(string dato, Nodo nodo)//Metodo de tipo Nodo llamado Insertar, al cual se le daran los parametros dato y nodo 
        {
            if(nodo == null)// si el parametro nodo es null 
            {               
                raiz = new Nodo();// se crea un nuevo nodo 
                raiz.Dato = dato;//se le da valor a la propiedad Dato de la clase nodo , siendo el valor el dato ingresado 
                raiz.Hijo = null;// la propiedad Hijo se vuelve null
                raiz.Hermano = null;// la propiedad Hermano se vuelve null
                return raiz;//se retorna raiz 
            }            

            if (nodo.Hijo == null)// si la propiedad Hijo de la clase Nodo es null
            {                
                Nodo temp = new Nodo();// se crea un nuevo nodo temporal 
                temp.Dato = dato;// se guarda el dato ingresado en la propiedad Dato 
                nodo.Hijo = temp;//a la propiedad Hijo se le asigna el nodo temp 
                return temp;//retorna temp 
            }
            
            else// si no 
            {                
                trabajo = nodo.Hijo; // al nodo trabajo creado con anterioridad se le da el valor de la propiedad Hijo        
                while(trabajo.Hermano != null)// mientras que la prop Hermano sea distinto de null
                {                    
                    trabajo = trabajo.Hermano;// se le da el valor al nodo trabajo de la prop Hermano
                }

                Nodo temp = new Nodo();// se crea un nuevo nodo temporal 
                temp.Dato = dato;// a la prop Dato se le da el valor del dato ingresado 
                trabajo.Hermano = temp;// la prop Hermano se iguala a temp 
                return temp;// se retorna temp 
            }         
        }

        public void ImprimirFiguraArbol(Nodo nodo)// se crea el metodo ImprimirFiguraArbol que pide un parametro llamado nodo 
        {
            if (nodo == null) // si el nodo es null 
                return;// lo retorna 

            for (int n = 0; n < i; n++)//de 0 hasta que la variable sea menor que i                 
                Console.Write("  ");// se escribe un doble espacion// con esto se hace la indentacion 
                                 
            Console.WriteLine(nodo.Dato);// se escribe el Dato del nodo             

            if(nodo.Hijo != null)// si el Hijo del nodo es distinto a null
            {
                i++;// se incrementa si se tiene hijos// con i se conoce la profundidad se tiene                 
                ImprimirFiguraArbol(nodo.Hijo); // se llama el metodo  ImprimirFiguraArbol          
                i--; // ya que regreso el Hijo se reduce el indice                               
            }

            if (nodo.Hermano != null)// si la prop Hermano es distinto a null             
                ImprimirFiguraArbol(nodo.Hermano);// se llama al metodo  ImprimirFiguraArbol

            if (nodo.Hermano != null && nodo.Hijo == null)// si la prop Hermano es distinto a null y Hijo es igual a null            
                altura++;// se incrementa la altura 
            
        }
        
        public void AlturaNivel()// Metodo que imprime la altura y el nivel 
        {                       
            Console.WriteLine("\nAltura: {0}\nNivel: {1}",altura,altura - 1);// Imprime en consola la Altura y el Nivel 
        }
        
        public void ImprimirArboles()// Metodo para imprimir los arboles
        {
            Console.WriteLine("Arbol A");// Escribe en consola

            Arbol arbolA = new Arbol();// se crea el objeto de tipo Arbol llamado arbolA

            Nodo raizA = arbolA.Insertar("E", null);// Se crea un Nodo llamado raizA, y al mismo tiempo se guarda en la variable E, que es la raiz
            
            Nodo A = arbolA.Insertar("A", raizA);// Se crea un nuevo nodo llamado A y al mismo tiempo se le guarda el dato A en la raiz 
            arbolA.Insertar("B", A);//se inserta en el nodo A el dato B 
            arbolA.Insertar("C", A);//se inserta en el nodo A el dato C
            arbolA.Insertar("D", A);//se inserta en el nodo A el dato D 
            arbolA.Insertar("F", raizA);// Se inserta en la raiz el dato F 
            arbolA.ImprimirFiguraArbol(raizA);// se imprime el arbol 
            arbolA.AlturaNivel();// se escriben en consola la altura y nivel con la llamada al metodo 
            Console.WriteLine("Ruta al elemento mas largo: E--> A--> (B,C,D)");//No pude hacer que se encontrara la ruta al elemento mas largo 
                                                                                // Se imprime en consola la ruta al elemento mas largo
            Console.ReadKey();//se detiene el programa 
            Console.Clear();// se limpia la consola 

            Console.WriteLine("Arbol B");// Se imprime en consola 

            Arbol arbolB = new Arbol();// se crea un objeto de tipo Arbol llamado arbolB

            Nodo raizB = arbolB.Insertar("C", null);// se crea un nuevo nodo raiz al cual se le guarda el valor de C 
            arbolB.Insertar("D", raizB);// se inserta en la raiz el dato D 
            arbolB.Insertar("F", raizB);// se inserta en la raiz el dato F
            arbolB.Insertar("G", raizB);// se inserta en la raiz el dato G 
            Nodo Ab = arbolB.Insertar("A", raizB);// Se guarda en un nuevo nodo Ab el dato a insertar llamado A 
            Nodo B = arbolB.Insertar("B", Ab);// se guarda en un nuevo nodo llamado B el dato B que se inserto en A 
            arbolB.Insertar("E", B);// se inserta en B el dato E 
            
            arbolB.ImprimirFiguraArbol(raizB);// se imprime el arbol 
            arbolB.AlturaNivel();// se imprime la altura y el nivel 
            Console.WriteLine("Ruta al elemento mas largo: C--> A--> B--> E");//No pude hacer que se encontrara la ruta al elemento mas largo 
                                                                               // Se imprime en consola la ruta al elemento mas largo
            Console.ReadKey();// se detiene el programa 
            Console.Clear();// se limpia la consola 

            Console.WriteLine("Arbol C");// se imprime en consola 
            Arbol arbolC = new Arbol();// se crea un nuevo objeto de tipo Arbol llamado arbolC 

            Nodo raizC = arbolC.Insertar("K", null);// Se guarda en el nodo raizC el valor de K 
            arbolC.Insertar("A", raizC);// Se inserta en la raiz el dato A 
            arbolC.Insertar("B", raizC);// Se inserta en la raiz el dato B
            arbolC.Insertar("C", raizC);// Se inserta en la raiz el dato C 
            Nodo D = arbolC.Insertar("D", raizC);// Se inserta en la raiz el dato D y se guarda en un nodo D  
            Nodo E = arbolC.Insertar("E", D);//// Se inserta en la raiz el dato E y se guarda en un nodo E  
            Nodo I = arbolC.Insertar("I", D);// Se inserta en el nodo D el dato I y se guarda en el nodo I 
            arbolC.Insertar("F", E);// Se inserta en el nodo E el valor de F 
            Nodo G =  arbolC.Insertar("G", E);// se inserta en E el dato G y se guarda en un nodo G 
            arbolC.Insertar("J", I);// se inserta en el nodo I el dato J             
            arbolC.Insertar("H", G);// se inserta en el nodo G el valor de H 
           
            arbolC.ImprimirFiguraArbol(raizC);// Se imprime el arbol
            arbolC.AlturaNivel();// se imprime la altura y el nivel 
            Console.WriteLine("Ruta al elemento mas largo: K--> D--> E--> G-->H");//No pude hacer que se encontrara la ruta al elemento mas largo 
                                                                                  // Se imprime en consola la ruta al elemento mas largo
            Console.WriteLine("La ruta de C: K-->C\n La ruta de H: K-->D-->E-->G-->H\nLa ruta de J: K-->D-->I-->J");//No pude hacer que se imprimieran las rutas de C,H,J automaticamente
                                                                                                                    //se imprimen en consola las rutas de C,H,J
            Console.ReadKey();// se detiene el programa 

        }
    }
}
