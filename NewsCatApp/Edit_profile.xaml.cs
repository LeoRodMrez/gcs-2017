using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NewsCatApp
{
	public partial class Edit_profile : ContentPage
	{
        private String name;
		public Edit_profile(String inputName)
		{
            this.name = inputName;
			InitializeComponent();
		}

		private void cancel_click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new Perfil(name));
		}
		private void save_click(object sender, EventArgs e)
		{
            name = userEntry.Text;
			Navigation.PushModalAsync(new Perfil(name));
		}
	}
}
