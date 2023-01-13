using CommunityToolkit.Mvvm.Input;
using FreeFoodApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFoodApp.ViewModels;

public partial class UserProfilePageViewModel : BaseViewModel
{

    [RelayCommand]
    Task BackBtn()=> Shell.Current.GoToAsync("/MainMenuPage");
    
    
}
