using RentACar_Mobile_.Models;

namespace RentACar_Mobile_;

public partial class DealershipEntryPage : ContentPage
{
	public DealershipEntryPage()
	{
		InitializeComponent();
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();

		listView.ItemsSource = await App.Database.GetDealershipsAsync();
	}

	async void OnDealershipAddedClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new DealershipPage
		{
			BindingContext = new Dealership()
		});
	}

	async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		if (e.SelectedItem != null)
		{
			await Navigation.PushAsync(new DealershipPage
			{
				BindingContext = e.SelectedItem as Dealership
			});
		}
	}

}