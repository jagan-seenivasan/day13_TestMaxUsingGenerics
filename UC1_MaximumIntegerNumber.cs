using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaxUsingGenerics
{
    class UC1_MaximumIntegerNumber
    {
        public void MaximumNumber(int num1, int num2, int num3)
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
