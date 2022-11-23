using System.Security.Cryptography;

namespace ca20221123
{
    
    internal class Program
    {
        static Random rnd = new Random();
        static int[] RandomszamTMB = new int[12];
        static void Main(string[] args)
        {
            randomszam();
        }

        private static void randomszam()
        {
            
            for (int i = 0; i < 12; i++)
            {
                RandomszamTMB[i] = rnd.Next(2, 38) * 8;
                if (RandomszamTMB[i] % 8 == 0)
                {
                    Console.Write($"{RandomszamTMB[i]}; ");
                }
                if ((i + 1) % 8 == 0) Console.Write('\n');
            }
           

        }
    }
}