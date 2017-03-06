using System;
using Xamarin.Forms;

namespace NewsCatApp
{
	public partial class NewsCatAppPage : ContentPage
	{
		public NewsCatAppPage()
		{
			InitializeComponent();
		}

        public void clickButton()
        {
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
			Navigation.PushModalAsync(new Login());
        }
    }
}
