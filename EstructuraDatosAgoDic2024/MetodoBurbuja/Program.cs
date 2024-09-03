using System.Diagnostics;

int[] vector = GenerarArreglo(10);

ImprimirArreglo(vector);

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
BurbujaNormal(vector);
stopwatch.Stop();
Console.WriteLine($"Burbuja Normal: {stopwatch.ElapsedMilliseconds} ms");

ImprimirArreglo(vector);


static void BurbujaNormal(int[] arreglo)
{
    int n = arreglo.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arreglo[j] > arreglo[j + 1])
            {
                // Intercambiar
                int temp = arreglo[j];
                arreglo[j] = arreglo[j + 1];
                arreglo[j + 1] = temp;
            }
        }
    }
}

static int[] GenerarArreglo(int tamaño)
{
    Random rand = new Random();
    int[] arreglo = new int[tamaño];
    for (int i = 0; i < tamaño; i++)
    {
        arreglo[i] = rand.Next(0, 10000);
    }
    return arreglo;
}

static void ImprimirArreglo(int[] arreglo)
{
    Console.WriteLine(string.Join(", ", arreglo));
}