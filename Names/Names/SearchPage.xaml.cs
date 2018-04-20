using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Names
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public string Keyword { get; set; }
        public SearchPage()
        {
            InitializeComponent();
            BindingContext = this;
            Keyword = "Vasile";
        }

        private async void Search_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new ResultsPage());
        }
    }
}