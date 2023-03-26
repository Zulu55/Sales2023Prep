namespace Sales.Mobile.BindingDemo;

public partial class BindigPage : ContentPage
{
	Person _person = new();

	public BindigPage()
	{
		InitializeComponent();

        _person = new Person
        {
            Address = "Calle Luna Calle Sol",
            Name = "Juan Zuluaga",
            Phone = "322 311 4620"
        };

        BindingContext = _person;
    }

    void btnOk_Clicked(System.Object sender, System.EventArgs e)
	{
        _person.Name = "Ledys";
        _person.Phone = "322 300 1232";
        _person.Address = "Avenida Siempre Viva";
	}
}
