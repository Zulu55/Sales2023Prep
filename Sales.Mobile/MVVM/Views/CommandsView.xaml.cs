namespace Sales.Mobile.MVVM.Views;
using Sales.Mobile.MVVM.ViewModels;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		BindingContext = new CommandsViewModel();
    }
}
