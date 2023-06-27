using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ConsoleApp1.ServiceReference1;

namespace Microsoft.ServiceModel.Samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Client WCF: Andrey R.";
            try
            {
                FunctionCalculateClient functionCalculateClient = new FunctionCalculateClient();

                functionCalculateClient.Open();

                double value1 = 100.00D;
                double value2 = 15.99D;
                double result = functionCalculateClient.Number8(value1, value2);
                Console.WriteLine($"Function 8: {result}");

                double result1 = functionCalculateClient.Number20(value1, value2);
                Console.WriteLine($"Function 20: {result1}");

                double result2 = functionCalculateClient.Number22(value1, value2);
                Console.WriteLine($"Function 22: {result2}");
                functionCalculateClient.Close();

                Console.WriteLine("Сеанс работы с сервисом завершен.");
            } catch (Exception ex)
            {
                Console.WriteLine($"Ошибка подключения к службе. {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
