using Plugin.LocalNotification;
using RentACar_Mobile_.Models;
//using Microsoft.Maui.Devices.Sensors;
//using Plugin.LocalNotification;
//using UserNotifications;
//using MediaPlayer;



namespace RentACar_Mobile_;

public partial class DealershipPage : ContentPage
{
	public DealershipPage()
	{
		InitializeComponent();
	}

	async void OnSaveButtonClicked(object sender, EventArgs e)
	{
		var dealership = (Dealership)BindingContext;
		await App.Database.SaveDealershipAsync(dealership);
		await Navigation.PopAsync();
	}

	async void OnShowMapButtonClicked(object sender, EventArgs e)
	{
		var dealership = (Dealership)BindingContext;
		var address = dealership.Adress;
		var locations = await Geocoding.GetLocationsAsync(address);
		var options = new MapLaunchOptions { Name = "My favorite dealership" };
		var location = locations?.FirstOrDefault();


        var myLocation = await Geolocation.GetLocationAsync();


        //var distance = myLocation.CalculateDistance(location, DistanceUnits.Kilometers);
        //if (distance < 4)
        //{
            //var request = new NotificationRequest
            //{
               // Title = "Ai de facut cumparaturi in apropiere!",
                //Description = address,
                //Schedule = new NotificationRequestSchedule
                //{
                   // NotifyTime = DateTime.Now.AddSeconds(1)
                //}
            //};
            //await LocalNotificationCenter.Current.Show(request);
        //}


        await Map.OpenAsync(myLocation, options);

        
        

        

	
	}
}