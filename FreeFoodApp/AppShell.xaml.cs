using FreeFoodApp.Views;

namespace FreeFoodApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage)); 
		Routing.RegisterRoute(nameof(MainMenuPage), typeof(MainMenuPage));
        Routing.RegisterRoute(nameof(ProductDetailPage), typeof(ProductDetailPage));
        Routing.RegisterRoute(nameof(AddProductPage), typeof(AddProductPage));
        Routing.RegisterRoute(nameof(UserProfilePage), typeof(UserProfilePage));
    }
}
