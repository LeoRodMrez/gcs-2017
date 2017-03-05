using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NewsCatApp
{
	public partial class Feedback : ContentPage
	{
		public Feedback()
		{
			InitializeComponent();
		}
		private void cancel_feedback_click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new Perfil());
		}
		private void send_feedback_click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new Perfil());
		}
	}
}
