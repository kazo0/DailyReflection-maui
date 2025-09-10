using DailyReflection.Presentation.ViewModels;
using System;




namespace DailyReflection.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DailyReflectionView : ContentPage
	{
		public DailyReflectionView()
		{
			InitializeComponent();
			BindingContext = Startup.ServiceProvider.GetService<DailyReflectionViewModel>();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (BindingContext is DailyReflectionViewModel vm)
			{
				MainThread.BeginInvokeOnMainThread(async () => await vm.Init());
			}
		}

		private void ToolbarItem_Clicked(object sender, EventArgs e)
		{
			DatePicker.Focus();
		}
	}
}