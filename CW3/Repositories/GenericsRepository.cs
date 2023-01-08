using CW3.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3.Repositories
{
	internal class GenericsRepository<T> where T : OnID
	{
		private List<T> items;

		public GenericsRepository()
		{
			items = new List<T>();
		}

		public void Add(T item)
		{
	        item.ID = items.Count + 1;
			items.Add(item);
		}
		public void Save() 
		{
			foreach (T item in items)
			{
				Console.WriteLine(item.ToString());
			}
		}
	}
}
