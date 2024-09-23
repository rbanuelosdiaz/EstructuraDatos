class Program
{
    public static void Main()
    {
        Stack<int> pila = new Stack<int>();
        
        pila.Push(1);
        pila.Push(2);
        pila.Push(3);
        pila.Push(4);
        pila.Push(5);

        Console.WriteLine("Imprimiento pila original:");
        ImprimirPila(pila);

        Console.WriteLine("Ejecución de metodo Pop()");
        pila.Pop();
        Console.WriteLine("Imprimiento pila:");
        ImprimirPila(pila);

        Console.WriteLine("Ejecución de metodo Push(6)");
        pila.Push(11);
        Console.WriteLine("Imprimiento pila:");
        ImprimirPila(pila);

        Console.WriteLine("Ejecuntando metodo peek()");
        Console.WriteLine(pila.Peek());

        Console.ReadKey();
    }

    public static void ImprimirPila(Stack<int> pila)
    {
        foreach (int x in pila)
        {
            Console.Write(x + ",");
        }
        Console.WriteLine("");
    }
}