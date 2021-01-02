using Laboratorio.Drive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio.Drive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesView : ContentPage
    {
        public Veiculos Veiculo { get; set; }

        private const decimal FREIO_ABS = 800;
        private const decimal AR_CONDICIONADO = 1000;
        private const decimal MP3_PLAYER = 500;

        public string ValorTotal
        {
            get
            {
                decimal total = Veiculo.Preco 
                    + (TemFreioABS ? FREIO_ABS : 0) 
                    + (TemArCondicionado ? AR_CONDICIONADO : 0) 
                    + (TemMP3Player ? MP3_PLAYER : 0);

                return $"Valor Total: R$ {total}";
            }
        }

        private bool temFreioABS;
        public bool TemFreioABS { get
            {
                return temFreioABS;
            }
            set
            {
                temFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));

                /*if (temFreioABS)
                    DisplayAlert("Freio ABS", "Ligado!", "OK");
                else
                    DisplayAlert("Freio ABS", "Desligado!", "OK");*/
            }
        }

        private bool temArCondicionado;
        public bool TemArCondicionado
        {
            get
            {
                return temArCondicionado;
            }

            set
            {
                temArCondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        private bool temMP3Player;
        public bool TemMP3Player
        {
            get
            {
                return temMP3Player;
            }

            set
            {
                temMP3Player = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string TextoFreioABS
        {
            get
            {
                return $"FREIO ABS - R$ {FREIO_ABS}";
            }
        }

        public string TextoArCondicionado
        {
            get
            {
                return $"AR CONDICIONADO - R$ {AR_CONDICIONADO}";
            }
        }

        public string TextoMP3Player
        {
            get
            {
                return $"MP3 PLAYER - R$ {MP3_PLAYER}";
            }
        }

        public DetalhesView(Veiculos veiculo)
        {
            InitializeComponent();
            this.Veiculo = veiculo;
            //this.Title = veiculo.Nome;
            this.BindingContext = this;
        }

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(this.Veiculo));
        }
    }
}