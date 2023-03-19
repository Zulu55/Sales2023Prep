﻿using Sales.Mobile.ControlsDemo;
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

            MainPage = new CommandsControlsDemo();
        }
    }
}