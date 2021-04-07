using System;

namespace Ejerc_Night_4
{
    /* 2 --- > Crear un programa que permita crear, cargar y obtener el menor y mayor valor de un vector, 
    La obtención del mayor y menor hacerlo en un único método que retorne dichos dos valores */

    class Program
    {
        private int[] array;
 
        public Program()
        {
            Console.Write("\n ¿De que dimension desea que sea el array?  \n");
            int dimension = int.Parse(Console.ReadLine());
            array = new int[dimension];
            Console.Clear();
        }
 
        public void Cargar()
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write("\n Ahora llena el array con numeros: \n");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
        }
 
        public void ObtenMayMe(out int numMa,out int numMe)
        {
            numMa=array[0];
            numMe=array[0];
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] > numMa)
                {
                    numMa = array[i];
                }
                else
                {
                    if (array[i] < numMe)
                    {
                        numMe = array[i];
                    }
                }
            }
        }
 
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            int mayor, menor;
            p.ObtenMayMe(out mayor, out menor);
            Console.WriteLine("\n El Mayor del array es {0} y El Menor es {1}.",mayor, menor);
            Console.WriteLine("\n Presiona una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
