using System;

namespace TestMaxUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    UC1_MaximumIntegerNumber maximumIntegerNumber = new UC1_MaximumIntegerNumber();
                    maximumIntegerNumber.MaximumNumber(10, 20, 40);
                    break;

                case 2:
                    UC2_MaxFloatNUmber maxFloatNUmber = new UC2_MaxFloatNUmber();
                    maxFloatNUmber.MaximumNumber(1.1, 5.2, 1.3);
                    break;

                case 3:
                    UC3_MaxString maxString = new UC3_MaxString();
                    maxString.MaximumString("peach", "Apple", "banana");
                    break;
                case 4:
                    Console.WriteLine("Integer");
                    new UsingGenerics<int>(82, 54, 23).testMax(82, 54, 23);
                    Console.WriteLine("Float");
                    new UsingGenerics<double>(22.1, 23.2, 22.3).testMax(22.1, 23.2, 22.3);
                    Console.WriteLine("string");
                    new UsingGenerics<string>("Apple", "banana", "peach").testMax("Apple", "banana", "peach");
                    break;

                case 5:
                    Console.WriteLine(" Integers : 29, 58, 45, 72, 31");
                    UC4_MaxCount<int> intValue = new UC4_MaxCount<int>(27, 52, 48, 73, 36);
                    intValue.Values();
                    Console.WriteLine(" Float : 64.2, 28.3, 83.3, 73.4, 93.3");
                    UC4_MaxCount<float> floatValue = new UC4_MaxCount<float>(64.2f, 28.3f, 83.3f, 73.4f, 93.3f);
                    floatValue.Values();
                    Console.WriteLine(" Char : N, K, S, R, J");
                    UC4_MaxCount<string> stringValue = new UC4_MaxCount<string>("N", "K", "S", "R", "J");
                    stringValue.Values();
                    break;
            }
        }
    }
}
