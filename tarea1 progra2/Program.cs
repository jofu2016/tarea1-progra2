using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1_progra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint valor1 = 0;
            // arreglos y matrices

            int[] edad = new int[] { 53, 50, 43, 70 }; // el arreglo es de 4 pocisiones ya dichas 
            float[] salario = new float[] { 1000, 7000, 2700, 7900 };

            String[] musicos = new String[4]; // aqui asignamos de cuantas posiciones es y despues rellenamos
            musicos[0] = "Zeta Bosio";
            musicos[1] = "Gustavo Cerati";
            musicos[2] = "Charlie Alberti";
            musicos[3] = "Richard Coleman";


            // ciclo for
            for (int i = 0; i < 4; i++)
            {
                float iva = 0;
                iva = ((float)(salario[i] * 0.13));
                Console.WriteLine("Musicos: " + musicos[i] + " Salarios: " + salario[i] + " IVA: " + iva + " Salario + IVA: " + (iva + salario[i]));
                Console.WriteLine(""); // para un salto de linea porque no se como hacerlo Xd 

            }

            // otro arreglo 
            String[] arreglo;
            Console.WriteLine("Digite el tamaño del arreglo");
            valor1 = uint.Parse(Console.ReadLine());
            arreglo = new string[valor1];

            for (int i = 0; i < arreglo.Length; i++)
            {

                Console.WriteLine("numero " + i);
            }
            Console.ReadLine();
        }
    }
}
