using RentACar_Mobile_.ViewModels;
namespace RentACar_Mobile_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class RegisterPage : ContentPage
	{
		public RegisterPage()
		{
			InitializeComponent();
			BindingContext = new RegisterViewModel(Navigation);
		}
	}
}