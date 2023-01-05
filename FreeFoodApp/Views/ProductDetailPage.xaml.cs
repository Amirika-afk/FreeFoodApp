using FreeFoodApp.ViewModels;

namespace FreeFoodApp.Views;

public partial class ProductDetailPage : ContentPage
{
	public ProductDetailPage(ProductDetailPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}