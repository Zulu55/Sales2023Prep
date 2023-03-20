namespace Sales.Mobile.ControlsDemo;

public partial class InputControlsDemo : ContentPage
{
	public InputControlsDemo()
	{
		InitializeComponent();
	}

	void slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
	{
		lblSlider.Text = slider.Value.ToString();
	}

	void stepper_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
	{
		if (stepper != null)
		{
			lblSlider.Text = stepper.Value.ToString();
		}
	}
}
