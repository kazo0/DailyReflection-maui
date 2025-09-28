using DailyReflection.Presentation.ViewModels;

namespace DailyReflection.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class AppShell : ContentPage
{
	public AppShell(ShellViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}