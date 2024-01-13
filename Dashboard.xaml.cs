using Newtonsoft.Json;
namespace RentACar_Mobile_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
	{
		public Dashboard()
		{
			InitializeComponent();
            GetProfileInfo();
        }
        private void GetProfileInfo()
        {
            var userInfo = JsonConvert.DeserializeObject<Firebase.Auth.FirebaseAuthClient>(Preferences.Get("FreshFirebaseToken", ""));
        }
    }
}