using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp_000
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{

            InitializeComponent ();
            /*
            ListView.ItemsSource = new List<MenuItem>()
            { 
                new MenuItem(){Name="Agregar transacción",Details="Agrega una nueva transacción",Action="AddTransButton_OnClicked"},
                new MenuItem(){Name="Modificar transacción",Details="Modifica una transacción",Action="ModTransButton_OnClicked"},
                new MenuItem(){Name="Eliminar transacción",Details="Agrega una nueva transacción",Action="DelTransButton_OnClicked"},
                new MenuItem(){Name="Exportar",Details="Exportar la informacion del usuario actual",Action="AddTransButton_OnClicked"}
            };*/
		}

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void AddTransButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTransactionPage());
        }
        private async void ModTransButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ModTransactionPage());
        }
        private async void DelTransButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }


    }
}
