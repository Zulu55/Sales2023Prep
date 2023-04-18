using System;
using System.Windows.Input;

namespace Sales.Mobile.MVVM.ViewModels
{
	public class CommandsViewModel
	{
		public CommandsViewModel()
		{
		}

		public string SearchTerm { get; set; }

		public ICommand ClickCommand => new Command(() => App.Current.MainPage.DisplayAlert("Title", "Message", "Ok"));

		public ICommand SearchCommand => new Command(() => App.Current.MainPage.DisplayAlert("Busqueda", $"Buscaste: {SearchTerm}", "Ok"));
    }
}

