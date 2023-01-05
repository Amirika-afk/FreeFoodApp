using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFoodApp.ViewModels;
[QueryProperty("Text", "TextID")]
public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    string text;
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;
    [ObservableProperty]
    string title;

    public bool IsNotBusy => !IsBusy;
}
