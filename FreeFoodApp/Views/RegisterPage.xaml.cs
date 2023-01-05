using CommunityToolkit.Mvvm.Input;
using FreeFoodApp.ViewModels;

namespace FreeFoodApp.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage(RegisterPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}