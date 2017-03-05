using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NewsCatApp
{
	public partial class Edit_profile : ContentPage
	{
		public Edit_profile()
		{
			InitializeComponent();
		}

		private void cancel_click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new Perfil());
		}
		private void save_click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new Perfil());
		}
	}
}
