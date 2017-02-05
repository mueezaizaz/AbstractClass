using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class BaseEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int pay { get; set; }

        public abstract void GetFullName();
        public abstract void PrintPay();
    }


}
