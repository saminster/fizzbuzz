using System;

namespace FizzBuzzApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TestRun();
        }

        public static void TestRun()
        {
            for(int i = 0 ; i<2000 ; i++)
            {
                Console.WriteLine(i);
                
            }

            Console.WriteLine("Press Return Key...");
            Console.Read(); 

        }
    }
}
