using System;
namespace Sales.Mobile.MVVM.ViewModels
{
	public class PeopleViewModel
	{
		public PeopleViewModel()
		{
			People = new List<string>()
			{
				"Juan",
				"Ledys",
				"Valery",
				"Ronal",
				"Geralin",
				"Benedict",
				"Isis",
				"Gaia",
				"Toño"
			};
		}

		public List<string> People { get; set; }
	}
}

