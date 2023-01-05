using FreeFoodApp.ViewModels;
using FreeFoodApp.Views;

namespace FreeFoodApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddTransient<LoginPage>();
		builder.Services.AddTransient<LoginPageViewModel>();

        builder.Services.AddTransient<RegisterPage>();
        builder.Services.AddTransient<RegisterPageViewModel>();

        builder.Services.AddTransient<MainMenuPage>();
        builder.Services.AddTransient<MainMenuPageViewModel>();

        builder.Services.AddTransient<ProductDetailPage>();
        builder.Services.AddTransient<ProductDetailPageViewModel>();

        builder.Services.AddSingleton<AddProductPage>();
        builder.Services.AddSingleton<AddProductPageViewModel>();

        builder.Services.AddTransient<UserProfilePage>();
        builder.Services.AddTransient<UserProfilePageViewModel>();

        return builder.Build();
	}
}
