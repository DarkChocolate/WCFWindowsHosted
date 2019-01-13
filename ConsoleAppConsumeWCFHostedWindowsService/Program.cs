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
            //This is a remote change to git
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
