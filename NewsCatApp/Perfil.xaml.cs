using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewsCatApp
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Perfil : ContentPage
    {
        private String name;
        public Perfil(String inputName)
        {
            this.name = inputName;
            InitializeComponent();
            this.userLabel.Text = name;
            this.emailLabel.Text = name + "@gmail.com"; 
            //BindingContext = new ContentPageViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Edit_profile(name));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Bookmark(name));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Feedback(name));
        }
    }

}
