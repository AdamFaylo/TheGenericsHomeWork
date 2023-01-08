using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyData.Repositories
{
	public delegate void ActionHendler<T>(object sender, DoWorkEventArgs e);
	public class ActionRepository<T>
	{
		private event ActionHendler<T> Action ;
		public string Name { get; set; }
		public ActionRepository(string name)
		{
			Name = name;
		}
		protected virtual void OnAction(int action)
		{
			ActionHendler<T> ac = Action as ActionHendler<T>;
			if (ac == null)
			{
				return;
			}
			ac(this,EventArgs<T>(action, Name));
		}


		public void Start(int tineToRun)
		{
			for (int i = 0; i < tineToRun; i++)
			{
				OnAction(2);
			}
		}
	}
}
