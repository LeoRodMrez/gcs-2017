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
			Navigation.PushModalAsync(new Feed());
		}
		private void signup_click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new Signup());
		}
	}
}
