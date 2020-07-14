using MobileApp_000.Models;
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
    public partial class MainPage : ContentPage
    {
        public Usuario NuevoUsuario { get; set; }

        private List<Transaccion> listTrans;

        public MainPage()
        {

            InitializeComponent();
            NuevoUsuario = new Usuario();
            NuevoUsuario.Nombre = "Luis Espindola";
            NuevoUsuario.Email = "luiesp27@gmail.com";
            NuevoUsuario.SaldoInicial = Convert.ToDouble(tbxSaldoInicial.Text);
            NuevoUsuario.SaldoActual = 100;   // aca va una funcion que calcula el saldo
            lblSaldoFinal.Text = Convert.ToString(NuevoUsuario.SaldoActual);
            BindingContext = NuevoUsuario;
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }
        private async void ConfigButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfigurationPage());
        }
        private async void AddTransButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTransactionPage());
        }

        private async void OnSaldoChanged(EventArgs e)
        {
            listTrans = await App.Database.GetTransactionsAsync();
            NuevoUsuario.SaldoInicial = Convert.ToDouble(tbxSaldoInicial.Text);
            NuevoUsuario.SaldoActual = Convert.ToDouble(CalcularSaldoFinal(listTrans));
            lblSaldoFinal.Text = Convert.ToString(NuevoUsuario.SaldoActual);
        }


        private List<Gasto> GastosPorCategoria(List<Transaccion> transaccions)
        {
            List<Gasto> lst = new List<Gasto>();
            decimal tot = 0;
            string act = "z", ant = "z";

            //ant = transaccions[0].MyCategory; // index out of range ??? idk
            foreach (var transaccion in transaccions)
            {
                act = transaccion.MyCategory;
                if ((act != ant) && (ant != "z")) // first time will be false
                {
                    Gasto gasto = new Gasto(tot, ant);
                    lst.Add(gasto);
                    tot = 0;
                }
                ant = act;  
                tot += transaccion.MyImporte;

            }

            return lst;
        }

        // Load a listView using the dataBase
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listTrans = await App.Database.GetTransactionsAsync();
            List<Transaccion> SortedList = listTrans.OrderBy(o => o.MyCategory).ToList();   // ordena la lista por categoria

            listita.ItemsSource = GastosPorCategoria(SortedList);

            //listita.ItemsSource = await App.Database.GetTransactionsAsync();
            //String resumen = Gastos.ItemsSource.ToString();
            //listView.ItemsSource = await App.Database.GetTransactionsAsync();
            NuevoUsuario.SaldoInicial = Convert.ToDouble(tbxSaldoInicial.Text);
            NuevoUsuario.SaldoActual = Convert.ToDouble(CalcularSaldoFinal(SortedList));
            lblSaldoFinal.Text = Convert.ToString(NuevoUsuario.SaldoActual);
        }

        private decimal CalcularSaldoFinal(List<Transaccion> ts)
        {
            decimal gastoTot = 0;

            foreach (var gasto in ts)
            {
                gastoTot += gasto.MyImporte;
            }

            return (Convert.ToDecimal(NuevoUsuario.SaldoInicial) - gastoTot);
        }

        private void tbxSaldoInicial_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }

        /*  OnListViewItemSelected
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                listTrans = await App.Database.GetTransactionsAsync();
                List<Transaccion> SortedList = listTrans.OrderBy(o => o.MyCategory).ToList();   // ordena la lista por categoria

                listita.ItemsSource = GastosPorCategoria(SortedList);
            }
        }
        */



    }
}