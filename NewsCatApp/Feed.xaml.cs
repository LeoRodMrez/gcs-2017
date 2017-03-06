using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewsCatApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Feed : ContentPage
    {
        public Feed()
        {
            InitializeComponent();
        }

        private void Leer_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Article());
        }

        private void Perfil_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Perfil());
        }
    }
}
