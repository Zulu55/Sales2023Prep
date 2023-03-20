using System.Diagnostics;

namespace Sales.Mobile.ControlsDemo;

public partial class TextControlsDemo : ContentPage
{
	public TextControlsDemo()
	{
		InitializeComponent();
	}

    void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    void Entry_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine(txtName.Text);
    }
}
