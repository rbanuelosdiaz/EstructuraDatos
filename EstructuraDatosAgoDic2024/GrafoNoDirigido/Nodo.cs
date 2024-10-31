using System.Collections.Generic;

namespace GrafoNoDirigido
{
    public class Nodo
    {
        public int Valor { get; set; }

        public List<Nodo> NodosAdyacentes { get; } = new List<Nodo>();

        //Constructor
        public Nodo(int valor) 
        {
            Valor = valor;
        }

        public void AgregarAdyacencia(Nodo node)
        {
            NodosAdyacentes.Add(node);
            node.NodosAdyacentes.Add(this); // Para un grafo no dirigido
        }

        public override string ToString()
        {
            return Valor.ToString();
        }
    }
}
