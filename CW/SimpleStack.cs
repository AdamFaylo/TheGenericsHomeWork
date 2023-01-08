using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
	public class SimpleStack<T>
	{
		private readonly T[] items;
		private int correntIndex = -1;
		public SimpleStack()
		{
			items = new T[10];
		}
		public int Count
		{
			get
			{
				return correntIndex + 1;
			}
		}
		public void Push(T item)
		{
			items[++correntIndex] = item;
		}
		public T Pop() 
		{
			T value = items[correntIndex--];
			return value;
		}
	}
}
