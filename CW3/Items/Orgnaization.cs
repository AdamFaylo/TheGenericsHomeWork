﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3.Items
{
	public class Orgnaization : OnID
	{
		
		public string Name { get; set; }
		public override string ToString()
		{
			return ID + "|" + Name;
		}
	}
}
