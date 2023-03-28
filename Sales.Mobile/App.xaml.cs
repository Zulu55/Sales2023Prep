using Sales.Mobile.BindingDemo;
using Sales.Mobile.ControlsDemo;
using Sales.Mobile.MVVM.Views;
using Sales.Mobile.PagesDemo;

namespace Sales.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MainPage());
            navPage.BarBackgroundColor = Colors.Chocolate;
            navPage.BarTextColor = Colors.White;

            MainPage = new PeopleView();
        }
    }
}