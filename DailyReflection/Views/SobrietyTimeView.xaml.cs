using DailyReflection.Presentation.ViewModels;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DailyReflection.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class SobrietyTimeView : ContentPage
{
	public SobrietyTimeView()
	{
		InitializeComponent();
		BindingContext = Startup.ServiceProvider.GetService<SobrietyTimeViewModel>();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		if (BindingContext is ViewModelBase vm)
		{
			vm.IsActive = true;
		}
	}
}