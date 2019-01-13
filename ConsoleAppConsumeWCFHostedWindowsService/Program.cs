using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConsumeWCFHostedWindowsService
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleCalculator = new WCFHostedWindowsServiceClient.SimpleCalculatorClient();

            Console.WriteLine(simpleCalculator.Multiply(100, 10));
            //This is my local changes to git
            Console.WriteLine(simpleCalculator.Add(120,40));
            //This is a remote change to git
            //System.Threading.Thread.Sleep(1000); //We don't need this command Mohsen, we will add it in next release.
            var a= "hello";
            Console.WriteLine($"We Add the last line of the code {a}");

            Console.WriteLine($"Here is my code{a}");
            //Console.ReadLine();

            Console.ReadLine();
        }
    }
}
