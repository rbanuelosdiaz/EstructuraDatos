using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FactorialN
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero = 3;

            int factorialIterativo = FactorialIterativo(numero);
            int factorialRecursivo = FactorialRecursivo(numero);

            Console.WriteLine("El factorial del numero {0} es {1}", numero, factorialRecursivo);
            Console.WriteLine("El factorial del numero {0} es {1}", numero, factorialIterativo);

            Console.ReadKey();
        }

        public static int FactorialIterativo(int numero)
        {
            int i, resultado = 1;

            for (i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }
        
        public static int FactorialRecursivo(int numero)
        {
            if (numero == 0) return 1;
            return numero * FactorialRecursivo(numero - 1);
        }

    }


}
