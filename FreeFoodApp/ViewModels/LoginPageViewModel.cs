
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFoodApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFoodApp.ViewModels
{
public partial class LoginPageViewModel : BaseViewModel
{


    [RelayCommand]
    async Task SignUpBtn()
    {
       await Shell.Current.GoToAsync("//LoginPage/RegisterPage");
    }

    [ObservableProperty]
    private string _userName;

    [ObservableProperty]
    private string _passWord;

    [RelayCommand]
    Task LoginBtn() => Shell.Current.GoToAsync("MainMenuPage");

    

}
}

  