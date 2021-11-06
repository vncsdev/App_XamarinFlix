using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinflix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logotipo.Source = ImageSource.FromResource("xamarinflix.Img.xamarin.png");

            btnCapitanMarvel.Source = ImageSource.FromResource("xamarinflix.Posters.capitamarvel.jpg");
            btnPanteraNegra.Source = ImageSource.FromResource("xamarinflix.Posters.panteranegra.jpg");
            btnShazam.Source = ImageSource.FromResource("xamarinflix.Posters.shazam.jpg");
            btnAladdin.Source = ImageSource.FromResource("xamarinflix.Posters.alladin.jpg");
            btnDumbo.Source = ImageSource.FromResource("xamarinflix.Posters.dumbo.jpg");
            btnVef.Source = ImageSource.FromResource("xamarinflix.Posters.vef.jpg");

        }

        private void btnCapitanMarvel_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Filmes.CapitanMarvel());
            } catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}