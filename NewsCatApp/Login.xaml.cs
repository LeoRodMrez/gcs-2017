using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NewsCatApp
{
	public partial class Login : ContentPage
	{
		public Login()
		{
			InitializeComponent();
		}

		private void login_click(object sender, EventArgs e)
		{
            String name = user.Text;
            String contraseña = pass.Text;
            if(name!=null && name.Length != 0 && contraseña!=null && contraseña.Length!=0)
            {
                Navigation.PushModalAsync(new Feed(name));
            }else
            {
                DisplayAlert("Alerta", "User o contraseña vacia", "cancel");
            }

        }
		private void signup_click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new Signup());
		}
	}
}
