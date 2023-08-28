﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidateRegulerExpressions
{
    internal class ValidateConditions
    {

        //for understaning regular expression
       public static void ValidateConsicutiveCondition()
        {
            string Pattern = "^[0-9]*[a-zA-Z]{3,}[a-zA-Z0-9]*$";
            string[] inputs = { "111", "1aaa", "aa11", "bcc", "1a1aab", "1abb23a" };

            foreach (string input in inputs)
            {
                if(Regex.IsMatch(input, Pattern))
                
                    Console.WriteLine("{0} is Valid", input);
                
                else
                    Console.WriteLine("{0} is Invalid", input);
            }
        }

        public static void ValidatePinCode()
        {
            string Pattern = "^[0-9]{6}$";
            string[] inputs = { "111", "306401" };
            foreach (string input in inputs)
            {
                if (Regex.IsMatch(input, Pattern))

                    Console.WriteLine("{0} is Valid", input);

                else
                    Console.WriteLine("{0} is Invalid", input);
            }
        }
    }
}
