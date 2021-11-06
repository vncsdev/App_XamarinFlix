using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarinflix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CapitanMarvel : ContentPage
    {
        public CapitanMarvel()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            poster.Source = ImageSource.FromResource("xamarinflix.Posters.capitamarvel.jpg");

            sinopse.Text = "Em Capitã Marvel, Carol Danvers (Brie Larson) é uma ex-agente da Força Aérea norte-americana, que, "
                         + "sem se lembrar de sua vida na Terra, é recrutada pelos Kree para fazer parte de seu exército de elite. Inimiga declarada dos Skrull, "
                         + "ela acaba voltando ao seu planeta de origem para impedir uma invasão dos metaformos, e assim vai acabar descobrindo a verdade sobre si, "
                         + "com a ajuda do agente Nick Fury (Samuel L. Jackson) e da gata Goose.";
        }
    }
}