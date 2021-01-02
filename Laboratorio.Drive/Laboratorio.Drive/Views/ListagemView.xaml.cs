using Laboratorio.Drive.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laboratorio.Drive.Views
{
    public partial class ListagemView : ContentPage
    {
        public List<Veiculos> Veiculos { get; set; }
        public ListagemView()
        {
            InitializeComponent();

            this.Veiculos = new List<Veiculos>
            {
                new Veiculos { Nome = "Azera V6", Preco = 60000 }
            };

            this.BindingContext = this;
            //listViewVeiculos.ItemsSource = this.Veiculos;
        }

        OnApa

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculos) e.Item;
            //DisplayAlert("Test Drive", string.Format("Veículo {0}, preço: {1}", veiculo.Nome, veiculo.Preco), "ok");
            Navigation.PushAsync(new DetalhesView(veiculo));
        }
    }
}
