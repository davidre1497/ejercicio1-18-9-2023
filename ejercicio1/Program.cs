using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    internal static class Program
    {
        public struct Empleado
        {

            public int codigo;
            public string nombre;
            public float salario;
        }
        private static object c;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // tipos de datos
            int num1, num2;
            short corto = 5660;
            num1 = 30;
            float flotante = 3.14f;
            double doble = 15.2d;
            decimal deci = 15.15m;
            byte b = 25;
            long larga = 155555555;
            ulong ulargo = 56;
            Boolean boleano = false;
            char letra = 'a';
            string cadena = "Hoy es lunes 18 de septiembre";

            // var // dynanmic

            var variable = 15.25f;

            dynamic dinamica = 25.3f;
            dinamica = "Nombre empleado";
            dinamica = true;
            dinamica = 'c';
            Empleado emp;
            emp.codigo = 1;
            emp.nombre = "david";
            emp.salario = 500;

            // arreglos
            int n = 4;
            string[] musico = new string[n];
            string[] temporal = new string[n];
            musico[0] = "Carlos";
            musico[1] = "Maria";
            musico[2] = "Sofia";
            musico[3] = "Eva";

            Console.WriteLine("Listado de musicos");
            Console.WriteLine(musico[0]);
            Console.WriteLine(musico[1]);
            Console.WriteLine(musico[2]);
            Console.WriteLine(musico[3]);

            n = 20;
            temporal = new string[n];
            musico = temporal;
            musico = new string[n];
            musico[0] = "Carlos";
            musico[1] = "Maria";
            musico[2] = "Sofia";
            musico[3] = "Eva";

            float[] salario = new float[4];
            /*
            * i =0,1,2,3,4
            
            */

            for (int i = 0; i < salario.Length; i++)
            {
                Console.WriteLine("Digite el salario");
                salario[i] = float.Parse(Console.ReadLine());
            }

            if (true)
            {

            }

            while (true)
            {

            }

            do
            {

            } while (true);

            Console.WriteLine("Listado de musicos");

            Console.WriteLine(musico[0]);
            Console.WriteLine(musico[1]);
            Console.WriteLine(musico[2]);
            Console.WriteLine(musico[3]);

            Console.ReadLine();
            string[] nombres = new string[] {"Ringo","George","Paul","john" };
           
        }
        }

        



        }
    

