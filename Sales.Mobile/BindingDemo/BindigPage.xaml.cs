namespace Sales.Mobile.BindingDemo;

public partial class BindigPage : ContentPage
{
	public BindigPage()
	{
		InitializeComponent();
	}

	void btnOk_Clicked(System.Object sender, System.EventArgs e)
	{
		var person = new Person
		{
			Address = "Calle Luna Calle Sol",
			Name = "Juan Zuluaga",
			Phone = "322 311 4620" 
		};

		BindingContext = person;

		//lblName.BindingContext = person;
		//lblName.SetBinding(Label.TextProperty, "Name");

		//var personBinding = new Binding();
		//personBinding.Source = person;
		//personBinding.Path = "Name";
		//lblName.SetBinding(Label.TextProperty, personBinding);
	}
}
