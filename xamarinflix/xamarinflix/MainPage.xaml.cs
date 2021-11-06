using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using xamarinflix.Categorias;

namespace xamarinflix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("xamarinflix.Img.xamarin.png");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                Navigation.PushAsync(new Aventura());

            } catch(Exception ex)
            {
                DisplayAlert("ops", ex.Message, "OK");
            }
        }
    }
}
