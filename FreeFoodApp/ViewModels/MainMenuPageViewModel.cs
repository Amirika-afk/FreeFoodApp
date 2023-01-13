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
    async Task AddProductBtn()
    {
        await Shell.Current.GoToAsync("AddProductPage");
    }
    [RelayCommand]
    Task UserProfileBtn() => Shell.Current.GoToAsync("UserProfilePage");

    [RelayCommand]
    Task ViewProduct() => Shell.Current.GoToAsync("ListOfProductPage");

    [RelayCommand]
    Task SignOutBtn() => Shell.Current.GoToAsync("////LoginPage");
    

}
