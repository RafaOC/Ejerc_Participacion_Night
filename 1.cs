using System;

namespace Ejerc_Night_3
{
    // 1 ---> Crear un metodo que retorne 5 valores random entre 1 y 30 mediante parametros por referencia.
class Program
    {
        public void CincoRandoms(out int num1, out int num2, out int num3, out int num4, out int num5)
        {
            Random r = new Random();
            num1 = r.Next(1, 30);
            num2 = r.Next(1, 30);
            num3 = r.Next(1, 30);
            num4 = r.Next(1, 30);
            num5 = r.Next(1, 30);            
        }
         static void Main(string[] args)
        {
            int random1, random2, random3, random4, random5;

            Program p = new Program();
            p.CincoRandoms(out random1, out random2, out random3, out random4, out random5);
            
            Console.WriteLine("Primer valor aleatorio:" + random1);
            Console.WriteLine("Segundo valor aleatorio:" + random2);
            Console.WriteLine("Tercer valor aleatorio:" + random3);
            Console.WriteLine("Cuarto valor aleatorio:" + random4);
            Console.WriteLine("Quinto valor aleatorio:" + random5);
            Console.ReadKey();
        }
    }
}
