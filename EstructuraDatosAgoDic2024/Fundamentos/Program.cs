using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona objPersona1 = new Persona();
            objPersona1.Nombre = "Juan";

            Persona objPersona2 = objPersona1;
            Persona objPersona3 = objPersona1;
            //objPersona2.Nombre = "Carolina";

            //Console.WriteLine(objPersona1.Nombre);
            //Console.WriteLine(objPersona2.Nombre);
            //Console.WriteLine(objPersona3.Nombre);

            Persona objPersona4 = new Persona();
            objPersona4.Nombre = objPersona1.Nombre;
            objPersona4.Nombre = "Edgar";

            Console.WriteLine(objPersona1.Nombre);
            Console.WriteLine(objPersona4.Nombre);
            Console.ReadLine();
        }
    }
}
