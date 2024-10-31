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
            //Método manual
            Nodo raiz = new Nodo();
            raiz.Valor = 3;

            raiz.NodoDer = new Nodo();
            raiz.NodoDer.Valor = 4;

            raiz.NodoIzq = new Nodo();
            raiz.NodoIzq.Valor = 2;

            raiz.NodoIzq.NodoIzq = new Nodo();
            raiz.NodoIzq.NodoIzq.Valor = 1;


            //Método automático
            int[] vector1 = { 15, 10, 20 };
            Nodo arbol1 = Nodo.ConstruirArbol(vector1);

            int[] vector2 = { 50, 30, 70, 20, 40, 60, 80, 10, 35, 45 };
            Nodo arbol3 = Nodo.ConstruirArbol(vector1);
        }
    }
}
