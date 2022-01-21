using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaxUsingGenerics
{
    public class Refactor_1_UsingGenerics<T> where T : IComparable
    {

        public T x, y, z;
        public UsingGenerics(T x, T y, T z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void testMax(T x, T y, T z)
        {
            if (x.CompareTo(y) > 0 && x.CompareTo(z) > 0 || x.CompareTo(y) >= 0 && x.CompareTo(z) > 0 || x.CompareTo(y) > 0 && x.CompareTo(z) > 0)
            {
                Console.WriteLine(x + " Greater than " + y + " and " + z);
            }
            else if (y.CompareTo(x) > 0 && y.CompareTo(z) > 0 || y.CompareTo(x) >= 0 && y.CompareTo(z) > 0 || y.CompareTo(x) > 0 && y.CompareTo(z) > 0)
            {
                Console.WriteLine(y + " Greater than " + x + " and " + z);
            }
            else if (z.CompareTo(x) > 0 && z.CompareTo(y) > 0 || z.CompareTo(x) >= 0 && z.CompareTo(y) > 0 || z.CompareTo(x) > 0 && z.CompareTo(y) > 0)
            {
                Console.WriteLine(z + " Greater than " + x + " and " + y);
            }
        }
    }
}
