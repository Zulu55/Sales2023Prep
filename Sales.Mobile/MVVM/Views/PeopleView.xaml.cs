namespace Sales.Mobile.MVVM.Views;
using Sales.Mobile.MVVM.ViewModels;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();
		BindingContext = new PeopleViewModel();
	}
}
