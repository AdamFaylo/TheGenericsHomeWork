using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Repositories
{
	public class EventArgs : EventArgs
	{
		public EventArgs(int level, string name)
		{
			LevelOfAction = level;
			Name = name;
		}

		public int LevelOfAction { get; set; }
		public string Name { get; set; }	
	}
}
