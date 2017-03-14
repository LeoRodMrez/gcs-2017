using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NewsCatApp
{
	public partial class Feedback : ContentPage
	{
        private String name;
		public Feedback(String inputName)
		{
            this.name = inputName;
			InitializeComponent();
		}
		private void cancel_feedback_click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new Perfil(name));
		}
		private void send_feedback_click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new Perfil(name));
		}
	}
}
