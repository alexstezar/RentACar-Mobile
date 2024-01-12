using System;
using RentACar_Mobile_.Data;
using System.IO;

namespace RentACar_Mobile_
{
    public partial class App : Application
    {
        static CarDatabase database;

        public static CarDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new CarDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Car.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}