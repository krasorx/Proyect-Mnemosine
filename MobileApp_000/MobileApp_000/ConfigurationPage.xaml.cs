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
	public partial class ConfigurationPage : ContentPage
	{
		public ConfigurationPage ()
		{
			InitializeComponent ();
		}
        private async void CreateUserButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserCreate());
        }
    }
}