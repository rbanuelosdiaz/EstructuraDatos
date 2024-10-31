using System;

namespace GrafoNoDirigido
{
    public class Program
    {
        static void Main(string[] args)
        {
            Grafo graph = new Grafo();

            Nodo node1 = graph.AgregarNodo(1);
            Nodo node2 = graph.AgregarNodo(2);
            Nodo node3 = graph.AgregarNodo(3);
            Nodo node4 = graph.AgregarNodo(4);

            node1.AgregarAdyacencia(node2);
            node1.AgregarAdyacencia(node3);
            node2.AgregarAdyacencia(node4);
            node3.AgregarAdyacencia(node4);

            Console.WriteLine("Representación del Grafo:");
            graph.ImprimirGrafo();

            Console.ReadKey();
        }
    }
}
