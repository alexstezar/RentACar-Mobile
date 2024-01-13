using Firebase.Auth;
using Firebase.Auth.Providers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_Mobile_.ViewModels
{
    internal class LoginViewModel 
    {
        private INavigation _navigation;
        public Command RegisterBtn { get; }
        public Command LoginBtn { get; }

        public string webApiKey = "AIzaSyCy2zuGwO34YUJiseBwTo8K5IyVxzAUhsg";
        public LoginViewModel(INavigation navigation)
        {
            this._navigation = navigation;
            RegisterBtn = new Command(RegisterBtnTappedAsync);
            LoginBtn = new Command(LoginBtnTappedAsync);
        }

        private async void LoginBtnTappedAsync(object obj)
        {
            await this._navigation.PushAsync(new CarEntryPage());
        }

        private async void RegisterBtnTappedAsync(object obj)
        {
            await this._navigation.PushAsync(new RegisterPage());
        }

        private string userName;
        private string userPassword;

        public event PropertyChangedEventHandler PropertyChanged;

        

        public string UserName
        {
            get => userName; set
            {
                userName = value;
                RaisePropertyChanged("UserName");
            }
        }

        public string UserPassword
        {
            get => userPassword; set
            {
                userPassword = value;
                RaisePropertyChanged("UserPassword");
            }
        }

     

        private void RaisePropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }
    }
}
