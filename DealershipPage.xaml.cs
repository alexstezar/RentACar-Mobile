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

        //await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

        var myLocation = await Geolocation.GetLocationAsync();

        //var myLocation = new Location(46.7731796289, 23.6213886738);

       // var distance = myLocation.CalculateDistance(location, DistanceUnits.Kilometers);

        await Map.OpenAsync(myLocation, options);

        
        

        

	
	}
}