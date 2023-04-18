using System;
using System.Windows.Input;
using PropertyChanged;

namespace Sales.Mobile.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
	public class DemoAutoPropertyChangedViewModel
	{
        public int Number1 { get; set; }

        public int Number2 { get; set; }

        public int Result { get; set; }

        public ICommand AddCommand => new Command(() => Result = Number1 + Number2);
    }
}

