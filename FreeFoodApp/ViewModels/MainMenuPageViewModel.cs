using CommunityToolkit.Mvvm.Input;
using FreeFoodApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFoodApp.ViewModels;
[QueryProperty("Text", "TextID")]
public partial class MainMenuPageViewModel : BaseViewModel
{

    [RelayCommand]
    async Task SignOutBtn()
    {
        await Shell.Current.GoToAsync("//LoginPage");
    }
    [RelayCommand]
    async Task AddProductBtn()
    {
        await Shell.Current.GoToAsync("AddProductPage");
    }
    [RelayCommand]
    async Task UserProfileBtn()
    {
        await Shell.Current.GoToAsync("UserProfilePage");
    }


}
