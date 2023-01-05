using CommunityToolkit.Mvvm.Input;
using FreeFoodApp.ViewModels;

namespace FreeFoodApp.Views;

public partial class AddProductPage : ContentPage
{
    public AddProductPage(AddProductPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;

    }

   
}