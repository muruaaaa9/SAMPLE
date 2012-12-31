using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Sample.Services.Host
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ServiceHost svcHost = null;
            try
            {
                using (svcHost = new ServiceHost(typeof(Sample.Services.Services.EmployeeService)))
                {

                    svcHost.Open();

                    Console.WriteLine("Simple Service is hosted");
                    Console.ReadKey();
                    svcHost.Close();
                }

            }
            catch (System.Exception oEx)
            {
                svcHost.Close();
                Console.WriteLine("Exception: " + oEx.Message);
            }


        }

    }
}
