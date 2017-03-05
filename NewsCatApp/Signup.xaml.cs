using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NewsCatApp
{
	public partial class Signup : ContentPage
	{
		public Signup()
		{
			InitializeComponent();
		}

		private void cancel_click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new Login());
		}
		private void signup_click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new Login());
		}
	}
}
