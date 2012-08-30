using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            for(int i = 0 ; i<101 ; i++)
            {
                Console.WriteLine(i);
                
            }

            Console.WriteLine("Press Return Key...");
            Console.Read(); 

        }
    }
}
