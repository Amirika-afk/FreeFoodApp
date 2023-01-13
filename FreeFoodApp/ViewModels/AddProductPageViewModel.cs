using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FreeFoodApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FreeFoodApp.ViewModels;
[QueryProperty(nameof(Text), "Text")]
public partial class AddProductPageViewModel : BaseViewModel
{
    public AddProductPageViewModel()
    {
    Items = new ObservableCollection<string>();

}

[ObservableProperty]
ObservableCollection<string> items;

[ObservableProperty]
string text;

[RelayCommand]
void Add()
{
    if (string.IsNullOrWhiteSpace(Text))
        return;
    Items.Add(Text);
    // add our item
    Text = string.Empty;

}
[RelayCommand]
void Delete(string s)
{
    if (Items.Contains(s))
    {
        Items.Remove(s);
    }
}

[RelayCommand]
async Task Tap(string s)
{
    //Use button with Tap Function but same as GoTo function
    //Tells the Shell to go to detail page directly and pass in data
    await Shell.Current.GoToAsync($"{nameof(ProductDetailPage)}?TextID={s}", 
        new Dictionary<string, object>
        {
            {nameof(ProductDetailPage), s}
        });
}
    [RelayCommand]
    Task GoBack() => Shell.Current.GoToAsync("MainMenuPage");
    

}
