using MauiCustoViagem.Models;

namespace MauiCustoViagem.Views;

public partial class calcularViagem : ContentPage
{


    double total = 0;
    double valor_pedagio = 0;

    public calcularViagem()
	{
		InitializeComponent();

        lbl_local.Text = "Origem: " + MainPage.vg.origem;
        lbl_destino.Text = "Destino: " + MainPage.vg.destino;
        lbl_local.IsVisible = false;


    }


    private void btn_newViagem_Clicked(object sender, EventArgs e)
    {

    }

  

    private async void btn_sum_Clicked(object sender, EventArgs e)
    {

        double consumo_Carro = ((MainPage.vg.distancia / MainPage.vg.rendimento) * MainPage.vg.valor_gas);

        List<pedagio> pedagios = await App.Db.GetAll();
        foreach (pedagio p in pedagios)
        {
            valor_pedagio += p.valor;
        }

        total = consumo_Carro + valor_pedagio;
        lbl_valor.Text = total.ToString("C");
        await DisplayAlert("Soma total:", $"Pedagio: {valor_pedagio.ToString("C")}\nConsumo: {consumo_Carro.ToString("C")}\n---------\nTotal: {total.ToString("C")}", "Ok");
        lbl_local.Text = "Valor: " + total;
        lbl_local.IsVisible = true;
    }
}