namespace Sales.Mobile.MVVM.Views;
using Sales.Mobile.MVVM.ViewModels;

public partial class DemoAutoPropertyChangedView : ContentPage
{
	public DemoAutoPropertyChangedView()
	{
		InitializeComponent();
		BindingContext = new DemoAutoPropertyChangedViewModel();
    }
}
