using System;

namespace savaitgalinis09_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________________________________________________________________________________________________");
            for(char a = 'a'; a <= 'z'; a++)
            {
                Console.WriteLine(a);
                if (a == 'j') Console.WriteLine("Jonas");
            }
            string vardas = Console.ReadLine();
            for(int i =0; i < 100; i++)
            {
                Console.WriteLine(vardas);
            }
            
            


        }
    }
}
