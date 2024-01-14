using RentACar_Mobile_.Models;

namespace RentACar_Mobile_;

public partial class CarEntryPage : ContentPage
{
	public CarEntryPage()
	{
		InitializeComponent();
	}




	protected override async void OnAppearing()
	{
		base.OnAppearing();
		var items = await App.Database.GetDealershipsAsync();

		listView.ItemsSource = await App.Database.GetCarsAsync();
	}

	async void OnCarAddedClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new CarPage
		{
			BindingContext = new Car()
		});
	}

	async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		if(e.SelectedItem != null) 
		{
			await Navigation.PushAsync(new CarPage
			{
				BindingContext = e.SelectedItem as Car

			});
		}
	}
}