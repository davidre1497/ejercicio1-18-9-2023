using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ejercicio3
{
    internal class Program
    {
        static float num1, num2; // variables locales
        static string carnet;
        static void Main(string[] args)
        {

            num1 = 25.3f;
            num2 = 14.3f;

            Console.WriteLine("Digite un numero");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite un numero");
            num2 = float.Parse(Console.ReadLine());
            carnet = Console.ReadLine();
            resta(num1, num2);
            suma(10, 5, "Alex");
            Console.Read();
        }

        {
        

        static void suma(float v1, float v2, string nombre)



                Console.WriteLine($"Suma: {v1+v2}");
                Console.WriteLine($"mi nombre es: {nombre}");
    }
           
           static void resta(float num1)
             {
    
                num1 = 1; num2 = 2;
            Console.WriteLine($"Resta: {(num1 - num2)}");
              }
    }
}
