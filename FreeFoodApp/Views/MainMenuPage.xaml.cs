using FreeFoodApp.ViewModels;

namespace FreeFoodApp.Views;

public partial class MainMenuPage : ContentPage
{
	public MainMenuPage(MainMenuPageViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}