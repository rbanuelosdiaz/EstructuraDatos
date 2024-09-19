// See https://aka.ms/new-console-template for more information
using UsoListas;

List<Persona> personas = new List<Persona>();

string respuesta = string.Empty;
do
{
    Persona persona = new Persona();

    Console.WriteLine("Ingresa el nombre de la persona:");
    persona.Nombre = Console.ReadLine();

    Console.WriteLine("Ingresa la edad de la persona:");
    persona.Edad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa el sexo de la persona:");
    persona.Sexo = Console.ReadLine();

    Console.WriteLine("Ingresa la altura de la persona:");
    persona.Altura = Convert.ToDouble(Console.ReadLine());

    personas.Add(persona);


    Console.WriteLine("Quieres ingresar otra persona?");
    respuesta = Console.ReadLine();

} while (respuesta.ToUpper() == "SI");



Console.WriteLine("Fin del programa");
Console.ReadKey();




