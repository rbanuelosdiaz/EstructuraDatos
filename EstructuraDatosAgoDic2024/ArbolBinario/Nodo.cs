using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class Nodo
    {
        public int Valor { get; set; }

        public Nodo NodoIzq { get; set; }

        public Nodo NodoDer { get; set; }

        // Constructor para inicializar un nodo con un valor
        public Nodo(int valor)
        {
            Valor = valor;
            NodoIzq = null;
            NodoDer = null;
        }

        public Nodo()
        {
            
        }

        // Método recursivo para insertar un valor en el árbol
        public void Insertar(int valor)
        {
            if (valor < Valor) // Si el valor es menor, va a la izquierda
            {
                if (NodoIzq == null)
                    NodoIzq = new Nodo(valor);
                else
                    NodoIzq.Insertar(valor);
            }
            else // Si el valor es mayor o igual, va a la derecha
            {
                if (NodoDer == null)
                    NodoDer = new Nodo(valor);
                else
                    NodoDer.Insertar(valor);
            }
        }

        // Método para construir el árbol a partir de un vector de enteros
        public static Nodo ConstruirArbol(int[] valores)
        {
            if (valores == null || valores.Length == 0)
                return null;

            Nodo raiz = new Nodo(valores[0]); // La raíz es el primer valor del arreglo
            for (int i = 1; i < valores.Length; i++)
            {
                raiz.Insertar(valores[i]);
            }
            return raiz;
        }
    }
}
}
