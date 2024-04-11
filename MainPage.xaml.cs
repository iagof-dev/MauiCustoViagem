using MauiCustoViagem.Models;
using static System.Net.Mime.MediaTypeNames;

namespace MauiCustoViagem
{
    public partial class MainPage : ContentPage
    {
        public static viagem vg;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_createPedagio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.criarPedagio());
        }

        private void btn_listPedagio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.listarPedagios());
        }

        private void btn_calcular_Clicked(object sender, EventArgs e)
        {
            vg = new viagem
            {
                valor_gas = Convert.ToDouble(txt_combustivel.Text),
                destino = txt_destino.Text,
                origem = txt_origem.Text,
                distancia = Convert.ToDouble(txt_distancia.Text),
                rendimento = Convert.ToDouble(txt_rendimento.Text),
            };


            Navigation.PushAsync(new Views.calcularViagem());
        }
    }

}
