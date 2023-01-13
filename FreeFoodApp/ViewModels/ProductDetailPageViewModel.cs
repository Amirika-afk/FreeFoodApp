using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFoodApp.Models;

namespace FreeFoodApp.ViewModels;
[QueryProperty(nameof(Iteminfo), "Iteminfo")]
[QueryProperty(nameof(Text), "Text")]
public partial class ProductDetailPageViewModel : BaseViewModel
{
    [ObservableProperty]
    String text;
    [ObservableProperty]
    Iteminfo iteminfo;

    [RelayCommand]
    Task GoBack() => Shell.Current.GoToAsync("MainMenuPage");


}
