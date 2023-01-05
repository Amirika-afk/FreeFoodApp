using CommunityToolkit.Mvvm.Input;
using FreeFoodApp.ViewModels;

namespace FreeFoodApp.Views;

public partial class UserProfilePage : ContentPage
{
	public UserProfilePage(UserProfilePageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	
}