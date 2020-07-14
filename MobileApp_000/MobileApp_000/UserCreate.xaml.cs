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
	public partial class UserCreate : ContentPage
	{
		public UserCreate ()
		{
			InitializeComponent ();
		}

        private void CrearUsuario() // 
        {
            Usuario usuario = new Usuario(username.Text, email.Text, (System.Convert.ToDouble(salary.Text)));
            DisplayAlert("Info", "Usuario creado con éxito", "OK");
            CreateBtn.Clicked += (sender, e) =>
            {
                String DirectoryName = @"C:\Testing\Usuarios\";
                //Create a Directory Using DependencyService  
                DependencyService.Get<IDirectory>().CreateDirectory(DirectoryName + username.Text + ".txt");
            };
        }
        private void Createbtn_OnClicked(object sender, EventArgs e)    //add async and awaits
        {
            this.CrearUsuario();
        }

    }
}