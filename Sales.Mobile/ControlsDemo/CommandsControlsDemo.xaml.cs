namespace Sales.Mobile.ControlsDemo;

public partial class CommandsControlsDemo : ContentPage
{
	public CommandsControlsDemo()
	{
		InitializeComponent();
	}

	void btnTest_Clicked(System.Object sender, System.EventArgs e)
	{
		DisplayAlert("Test", "This is a demo", "Ok");
	}

	void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		DisplayAlert("RadioButton", $"Changed: {e.Value}", "Ok");
	}

    void searchControl_SearchButtonPressed(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("Searching", $"Searching: {searchControl.Text}", "Ok");
    }

	void SwipeItem_Invoked(object sender, EventArgs e)
	{
		DisplayAlert("SwipeView", $"Element Tapped", "Ok");
	}
}
