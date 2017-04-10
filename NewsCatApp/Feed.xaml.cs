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
        private String name;
        public Feed(String inputName)
        {
           
            if (inputName != null && inputName.Length != 0)
            {
                name = inputName;
            }
            InitializeComponent();
        }

        private void Leer_Clicked1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://deportes.elpais.com/deportes/2017/04/10/actualidad/1491849801_212165.html"));
        }

        private void Leer_Clicked2(object sender, EventArgs e)
        {

            Device.OpenUri(new Uri("http://elpais.com/elpais/2017/04/10/talento_digital/1491824646_420176.html"));
        }

        private void Perfil_Clicked(object sender, EventArgs e)
        {

            Navigation.PushModalAsync(new Perfil(name));
        }
        private void up1(object sender, EventArgs e)
        {
            p1.Text = "+1";
        }
        private void down1(object sender, EventArgs e)
        {
            p1.Text = "-1";
        }

        private void up2(object sender, EventArgs e)
        {
            p2.Text = "+1";
        }
        private void down2(object sender, EventArgs e)
        {
            p2.Text = "-1";
        }
    }
}
