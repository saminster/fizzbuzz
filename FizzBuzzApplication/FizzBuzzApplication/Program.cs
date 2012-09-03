using System;
using FizzBuzzApplication.Library;
using FizzBuzzApplication.Output;

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
            Logger logger = new Logger();
            for(int i = 1 ; i<1000 ; i++)
            {
                string numToWrite = PrepareFBValue(i);
                Console.WriteLine(numToWrite);
                logger.CreateFizzBuzzLogger(numToWrite);
            }

            Console.WriteLine("Press Return Key...");
            Console.Read(); 

        }

        public static string PrepareFBValue(int num)
        {
            var rangeValid = new RangeValidator();
            var fbNumber = new FBNumber();
            fbNumber.chkFBNumber = num;

            string returnValue = rangeValid.DetermineNumberLabel(fbNumber);

            return returnValue;
        }
    }
}
