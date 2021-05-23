using System;

namespace Metodos_y_Arrays___C2_Ej13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarray;
            int longitud;
            Random aleatorio = new Random();

            Console.WriteLine("Introduce la longitud del array:");
            longitud = Convert.ToInt32(Console.ReadLine());
            miarray = new int[longitud];


            for (int i = 0; i < miarray.Length; i++)
            {
                miarray[i] = aleatorio.Next(1,10);
                Console.WriteLine(miarray[i]);
            }
            
        }
    }
}
