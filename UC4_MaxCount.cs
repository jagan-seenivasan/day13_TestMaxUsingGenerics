using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaxUsingGenerics
{
	public class UC4_MaxCount<T> where T : IComparable<T>
	{
		List<T> maxValue = new List<T>();
		public UC4_MaxCount(params T[] values)
		{
			this.ValuesBuilder(values);
		}
		public void ValuesBuilder(T[] maxValue)
		{
			foreach (T item in maxValue)
			{
				this.maxValue.Add(item);
			}
		}
		public void Values()
		{
			this.maxValue.Sort();
			Console.WriteLine(this.maxValue[this.maxValue.Count - 1]);
		}
	}
}
