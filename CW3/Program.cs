using CW3.Items;
using CW3.Repositories;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
	internal class Program
	{
		static void Main(string[] args)
		{
			GenericsRepository<Employee> genericsRepository = new GenericsRepository<Employee>();//lastName//FirstNAME
			genericsRepository.Add(new Employee { FirstName = "Adam", LastName = "coco" });
			genericsRepository.Add(new Employee { FirstName = "Eran", LastName = "Faylo" });
			genericsRepository.Add(new Employee { FirstName = "Simon", LastName = "Faylo" });
			genericsRepository.Add(new Employee { FirstName = "Adam", LastName = "Faylo" });
			genericsRepository.Save();

			Console.WriteLine("-------------");

			GenericsRepository<Orgnaization> orgnaization = new GenericsRepository<Orgnaization>();
			orgnaization.Add(new Orgnaization { Name = "H&M"});
			orgnaization.Add(new Orgnaization { Name = "H&M-HOME" });
			orgnaization.Save();

		}
	}
}

