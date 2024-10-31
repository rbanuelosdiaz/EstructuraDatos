using System;
using System.Collections.Generic;

namespace GrafoNoDirigido
{
    public class Grafo
    {
        private readonly List<Nodo> Nodos = new List<Nodo>();

        public Nodo AgregarNodo(int valor)
        {
            var nuevoNodo = new Nodo(valor);
            Nodos.Add(nuevoNodo);
            return nuevoNodo;
        }

        public void ImprimirGrafo()
        {
            foreach (var nodo in Nodos)
            {
                Console.Write($"Nodo {nodo.Valor}: ");

                foreach (var adyacente in nodo.NodosAdyacentes)
                {
                    Console.Write($"{adyacente.Valor} ");
                }
                Console.WriteLine();
            }
        }
    }
}
