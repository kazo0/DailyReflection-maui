using DailyReflection.Presentation.ViewModels;




namespace DailyReflection.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class DailyReflectionView : ContentView
{
	public DailyReflectionView()
	{
		InitializeComponent();
		//BindingContext = MauiProgram.ServiceProvider?.GetService<DailyReflectionViewModel>();
		Loaded += DailyReflectionView_Loaded;

	}

	private void DailyReflectionView_Loaded(object? sender, EventArgs e)
	{
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