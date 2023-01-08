using MyData.Items;
using MyData.Repositories;
using System;

namespace MyApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			GenericRepository<Employee> employeeRepo = new GenericRepository<Employee>();
			employeeRepo.Add(new Employee { FirstName = "Adam", LastName = "Faylo" });
			employeeRepo.Add(new Employee { FirstName = "Simon", LastName = "Piscapoe" });
			employeeRepo.Save();

            ActionRepository<MyData.Repositories.EventArgs> n = new ActionRepository<MyData.Repositories.EventArgs>("Adam");
			n.Start(3);

			Console.WriteLine("---------------");

			GenericRepository<Organization> organizationRepo = new GenericRepository<Organization>();
			organizationRepo.Add(new Organization {Name = "H&M"});
			organizationRepo.Add(new Organization { Name = "Zara" });
			organizationRepo.Save();
		}
	}
}