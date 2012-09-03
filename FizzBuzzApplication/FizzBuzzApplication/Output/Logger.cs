using System.IO;

namespace FizzBuzzApplication.Output
{
    public class Logger
    {
        private StreamWriter log;

        public void CreateFizzBuzzLogger(string logLine)
        {
            if(!File.Exists("FizzBuzzLog.txt"))
            {
                log = new StreamWriter("FizzBuzzLog.txt");
            }
            else
            {
                log = File.AppendText("FizzBuzzLog.txt");
            }

            log.WriteLine(logLine);
            log.Close();
        }


    }
}