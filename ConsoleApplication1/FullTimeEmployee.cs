using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class FullTimeEmployee : BaseEmployee
    {
        public override void GetFullName()
        {

            Console.WriteLine(FirstName + " " + LastName);
            
        }

        public override void PrintPay()
        {
            Console.WriteLine(pay);
            
        }
    }
}
