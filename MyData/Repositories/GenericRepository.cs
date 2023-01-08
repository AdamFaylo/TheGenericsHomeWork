using MyData.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Repositories
{
	internal class GenericRepository<T> where T : ItemBase
	{
		private List<T> items;
		public GenericRepository()
		{
			items = new List<T>();

		}
		public void Add(T item)
		{
			item.ID = items.Count + 1;
			items.Add(item);
		}
		public void Remove(T item)
		{
			items.Remove(item);
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
