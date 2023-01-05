using FreeFoodApp.ViewModels;

namespace FreeFoodApp.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
    void LoginBtn()
    {
        string UserName = txtUsername.Text;
        string Password = txtPassword.Text;
        if (UserName == null || Password == null)
        {
            DisplayAlert("Warning", "Please input Username & Password", "Ok");
            return;
        }


    }

}