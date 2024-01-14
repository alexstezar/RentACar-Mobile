using RentACar_Mobile_.Models;
using Microsoft.Maui.Controls;
namespace RentACar_Mobile_;

public partial class CarPage : ContentPage
{
   

	public CarPage()
	{
		InitializeComponent();
		Car car = new Car();
		BindingContext = car;
        
	}




	async void OnSaveButtonClicked(object sender, EventArgs e)
	{
		var favcar = (Car)BindingContext;

		if (favcar != null )
		{
           
                favcar.Name = DropdownMenu.SelectedItem as string;

            await App.Database.SaveCarAsync(favcar);
            

            await Navigation.PopAsync();
		}


		
    }



	async void OnDeleteButtonClicked(object sender, EventArgs e)
	{
		var favcar = (Car)BindingContext;
		await App.Database.DeleteCarAsync(favcar);
		await Navigation.PopAsync();
	}

    

}