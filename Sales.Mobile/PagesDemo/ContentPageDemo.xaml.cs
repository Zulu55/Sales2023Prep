namespace Sales.Mobile.PagesDemo;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

	void Button_Clicked(System.Object sender, System.EventArgs e)
	{
		Navigation.PopAsync();
	}
}
