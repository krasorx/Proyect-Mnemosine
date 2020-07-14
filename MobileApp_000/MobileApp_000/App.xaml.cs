using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp_000.Views;
using MobileApp_000.Data;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MobileApp_000
{
    public partial class App : Application
    {
        static TransactionDataBase database;

        public static TransactionDataBase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                    TransactionDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "Transaccion03.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
            //MainPage = new MainPage();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
