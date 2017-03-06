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
    public partial class Bookmark : ContentPage
    {
        public Bookmark()
        {
            InitializeComponent();
        }
        private void Perfil_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Perfil());
        }

        private void Leer_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Article());
        }
    }
}
