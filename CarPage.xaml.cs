using RentACar_Mobile_.Models;

namespace RentACar_Mobile_;

public partial class CarPage : ContentPage
{
	public CarPage()
	{
		InitializeComponent();
	}

	async void OnSaveButtonClicked(object sender, EventArgs e)
	{
		var favcar = (Car)BindingContext;
        
        await App.Database.SaveCarAsync(favcar);
		await Navigation.PopAsync();
	}

	async void OnDeleteButtonClicked(object sender, EventArgs e)
	{
		var favcar = (Car)BindingContext;
		await App.Database.DeleteCarAsync(favcar);
		await Navigation.PopAsync();
	}

   
}