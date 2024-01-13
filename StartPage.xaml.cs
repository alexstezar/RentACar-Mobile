using RentACar_Mobile_.ViewModels;

namespace RentACar_Mobile_;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel(Navigation);
    }
}