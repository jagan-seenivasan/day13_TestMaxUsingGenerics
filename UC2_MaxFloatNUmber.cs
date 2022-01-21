using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaxUsingGenerics
{
    class UC2_MaxFloatNUmber
    {
        public void MaximumNumber(double num1, double num2, double num3)
        {


            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 || num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                Console.WriteLine(num1 + " Greater than " + num2 + " and " + num3);
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 || num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 || num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                Console.WriteLine(num2 + " Greater than " + num1 + " and " + num3);
            }
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 || num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0 || num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                Console.WriteLine(num3 + " Greater than " + num1 + " and " + num2);
            }

        }
    }
}
