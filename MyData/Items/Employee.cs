using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Items
{
	public class Employee : ItemBase
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public override string ToString()
		{
			return ID + "|" + FirstName+ " " + LastName;	
		}
	}
}
