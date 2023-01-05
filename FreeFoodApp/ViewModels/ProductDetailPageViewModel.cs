using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFoodApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFoodApp.ViewModels;
[QueryProperty("Text", "TextID")]
public partial class ProductDetailPageViewModel : BaseViewModel
{
    [ObservableProperty]
    String text;

    [RelayCommand]
    async Task GoBack(String s)
    {
       await Shell.Current.GoToAsync($"{nameof(AddProductPage)}?TextID={s}",
        new Dictionary<string, object>
        {
            {nameof(AddProductPage), s}
        });
    }


}
