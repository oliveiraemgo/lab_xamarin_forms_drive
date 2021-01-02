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
    public partial class AgendamentoView : ContentPage
    {
        public Veiculos Veiculo { get; set; }

        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }

        private DateTime dataAgendamento = DateTime.Today;
        public DateTime DataAgendamento 
        {
            get
            {
                return dataAgendamento;
            }
            set
            {
                dataAgendamento = value;
            }
        }

        public TimeSpan HoraAgendamento { get; set; }

        public AgendamentoView(Veiculos veiculo)
        {
            InitializeComponent();
            //this.Title = veiculo.Nome;
            this.Veiculo = veiculo;
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var msg = string.Format(
                @"Nome: {0}
                Fone: {1}
                E-mail: {2}
                Data do Agendamento: {3}
                Hora do Agendamento: {4} ", 
                Nome, Fone, Email, DataAgendamento.ToString("dd/MM/yyyy"), HoraAgendamento);
            
            DisplayAlert("Agendamento", msg, "OK");
        }
    }
}