// See https://aka.ms/new-console-template for more information
List<int> listaNumeros = new List<int>();
string respuesta = string.Empty;
do
{
    Console.WriteLine("Ingresa un numero entero:");
    int numero = Convert.ToInt32(Console.ReadLine());
    listaNumeros.Add(numero);

    Console.WriteLine("Quieres ingresar otro numero?");
    respuesta = Console.ReadLine();

} while (respuesta.ToUpper() == "SI");

foreach (int numero in listaNumeros)
{
    Console.WriteLine($"{numero}");
}

Console.WriteLine("Fin del programa");
Console.ReadKey();




