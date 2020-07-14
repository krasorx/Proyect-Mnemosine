using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp_000;
using MobileApp_000.Models;

namespace MobileApp_000
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddTransactionPage : ContentPage
	{
		public AddTransactionPage ()
		{
			InitializeComponent ();
		}

        async void OnAceptButtonClicked(object sender, EventArgs e)
        {
            Transaccion transaction = new Transaccion();
            //var transaction = (Transaccion)BindingContext;
            transaction.MyDateTime = Fecha.Date;
            transaction.MyDescription = Descripcion.Text;
            transaction.MyCategory = Categoria.Text.ToLower();
            transaction.MyImporte = Convert.ToDecimal(Importe.Text);
            await App.Database.SaveTransactionAsync(transaction);
            await Navigation.PopAsync();
            await DisplayAlert("Información","Operación realizada con éxito","OK");
        }

    }
}