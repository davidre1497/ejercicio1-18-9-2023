using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // ACUMULADORES Y CONTADORES
            int contador = 0;
            int total = 0; int salario =0 
            //contadores 
            contador = contador + 1;
            contador++;
            ++contador;
            contador--;
            --contador;

            //Acumuladores

            total = total + salario;
            total += salario;
            total += 5;
            total *= 2;
            total /= 6;

            // sistema para calcular el promdio de n estudiantes
            //calcular cuantos estudiantes tienen una nota superior al prome

            string[] Estudiantes = new string[4];
            float[] notas = new float[4];
            float promedio = 0;

            for (int i = 0; i < Estudiantes.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del estuudiante");
            }





            Console.ReadLine();
        }
    }
}
