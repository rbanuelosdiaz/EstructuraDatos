using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Método automático
            int[] vector1 = { 8, 3, 1, 20, 5, 10, 7, 4 };
            Nodo arbol1 = Nodo.ConstruirArbol(vector1);

            arbol1.Preorden(arbol1);

            Console.ReadKey();
        }
    }
}
