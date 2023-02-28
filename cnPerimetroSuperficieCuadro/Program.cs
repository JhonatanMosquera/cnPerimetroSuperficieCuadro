using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnPerimetroSuperficieCuadro
{
    internal class Program
    {
        /// <summary>
        /// Nombre:jhonatan stiven mosquera moreno
        /// fecha:24/02/2023
        /// descripción: SuperficieCUadro
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese por favor la medida de un lado del cuadro");
            double lado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El perimetro del cuadro es " + PerimetroCuadro(lado));
            Console.WriteLine("la superficie del cuadrado es " + SuperficieCuadro(lado));
            Console.ReadKey();

        }

        static double PerimetroCuadro(double lado)
        {
            double resultado = lado * 4;
            return resultado;
        }
        static double SuperficieCuadro(double lado)
        {
            double resultado = lado * lado;
            return resultado;
        }



    }
}
