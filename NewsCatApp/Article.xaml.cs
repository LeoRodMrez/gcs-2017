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
    public partial class Article : ContentPage
    {
        private String nombre = "";
        public Article(String inputName)
        {
            nombre = inputName;
            InitializeComponent();
        }
    }
}
