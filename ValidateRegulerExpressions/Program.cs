using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateRegulerExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            ValidateConditions.ValidateConsicutiveCondition();
            ValidateConditions.ValidatePinCode();
            ValidateConditions.ValidateEmail();
            Console.ReadLine();
        }
    }
}
