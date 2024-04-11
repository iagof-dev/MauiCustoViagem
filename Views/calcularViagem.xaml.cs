using MauiCustoViagem.Models;

namespace MauiCustoViagem.Views;

public partial class calcularViagem : ContentPage
{


    double total = 0;
    double valor_pedagio = 0;

    public calcularViagem()
	{
		InitializeComponent();

        
        

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

        await DisplayAlert("Soma total:", $"Pedagio: {valor_pedagio.ToString("C")}\nConsumo: {consumo_Carro.ToString("C")}\n---------\nTotal: {total.ToString("C")}", "Ok");

    }
}