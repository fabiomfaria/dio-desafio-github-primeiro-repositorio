using System;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arrayInteiros = new int[3]; 
           
           arrayInteiros[0] = 10;
           arrayInteiros[1] = 20;
           arrayInteiros[2] = 30;

            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                System.Console.WriteLine($"[{i}] = " + arrayInteiros[i]);
            }

            System.Console.WriteLine("---------------------");

            foreach (var item in arrayInteiros)
            {
               System.Console.WriteLine(item); 
            }
        }
    }
}
