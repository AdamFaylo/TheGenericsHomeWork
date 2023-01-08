using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Items
{
	public class Organization : ItemBase
	{	
		public string Name { get; set; }

		public override string ToString()
		{
			return ID + "|" + Name;
		}
	}
}
