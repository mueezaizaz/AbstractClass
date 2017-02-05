using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee ftp = new FullTimeEmployee();

            ftp.FirstName = "Mueez";
            ftp.LastName = "Aizaz";
            ftp.pay = 200;

            ftp.GetFullName();
            ftp.PrintPay();
            Console.WriteLine("Press enter to close");
            Console.ReadLine();

        }
    }
}
