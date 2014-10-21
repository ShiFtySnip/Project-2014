using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetData();
            Console.ReadLine();
        }

        private static void GetData()
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            client.GetDataCompleted += client_GetDataCompleted;
            client.GetDataAsync(5);
        }

        private static void client_GetDataCompleted(object sender, ServiceReference1.GetDataCompletedEventArgs e)
        {
            Console.WriteLine("Result from traditional async: {0}", e.Result);
        }
    }
}
