using FreeFoodApp.ViewModels;

namespace FreeFoodApp.Views;

public partial class ListOfProductPage : ContentPage
{
	public ListOfProductPage(ListOfProductViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}