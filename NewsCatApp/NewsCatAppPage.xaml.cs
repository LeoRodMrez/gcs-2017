using System;
using Xamarin.Forms;

namespace NewsCatApp
{
	public partial class NewsCatAppPage : ContentPage
	{
		public NewsCatAppPage()
		{
			InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(2), () =>
            {  
                Navigation.PushModalAsync(new Login());
                return false;
            });

        }
    }
}
