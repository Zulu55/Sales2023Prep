using System;
using Sales.Mobile.MVVM.Models;

namespace Sales.Mobile.MVVM.ViewModels
{
	public class PeopleViewModel
	{
		public PeopleViewModel()
		{
			People = new List<Person>()
			{
                new Person { Name = "Juan", Age = 48, BirthDate = new DateTime(1974, 9, 23), LunchTime = new TimeSpan(12, 0,0), Married = true, Weight = 89 },
                new Person { Name = "Ledys", Age = 42, BirthDate = new DateTime(1981, 1, 11), LunchTime = new TimeSpan(13, 0,0), Married = true, Weight = 56 },
                new Person { Name = "Valery", Age = 12, BirthDate = new DateTime(2010, 2, 27), LunchTime = new TimeSpan(12, 30,0), Married = false, Weight = 38 },
                new Person { Name = "Ronal", Age = 23, BirthDate = new DateTime(2000, 1, 20), LunchTime = new TimeSpan(14, 0,0), Married = false, Weight = 47 },
			};
		}

		public List<Person> People { get; set; }
	}
}

