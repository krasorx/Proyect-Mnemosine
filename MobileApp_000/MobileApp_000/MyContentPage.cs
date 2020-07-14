using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp_000
{
    public class MyContentPage : ContentPage
    {
        public MyContentPage()
        {
           
            var label = new Label
            {
                Text = "Escribe tu nombre",
                TextColor = Color.White
                
            };

            var txtNombre = new Entry
            {
                Placeholder = "Escribe tu nombre"
            };

            var btnIngresar = new Button
            {
                Text = "Ingresar",
                BorderColor = Color.Green,
                BackgroundColor = Color.DarkGray
  
            };

            btnIngresar.Clicked += (sender, e) =>
            {
                DisplayAlert("Mensaje", txtNombre.Text, "OK");
            };


            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 15,
                BackgroundColor = Color.Black,
                Children = { label,txtNombre,btnIngresar}
                
            };


        }



    }
}
