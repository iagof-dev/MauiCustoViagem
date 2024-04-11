using MauiCustoViagem.Models;

namespace MauiCustoViagem.Views;

public partial class criarPedagio : ContentPage
{
	public criarPedagio()
	{
		InitializeComponent();
	}

    private async void btn_enviar_Clicked(object sender, EventArgs e)
    {
		try
		{
			pedagio p = new pedagio();
			p.local = txt_local.Text;
			p.valor = Convert.ToDouble(txt_valor.Text);

			await App.Db.Insert(p);
		}
		catch (Exception ex)
		{
			await DisplayAlert("Erro", ex.Message, "Ok");
        }
        await DisplayAlert("Sucesso!", "Pedagio foi adicionado", "Ok");
    }

    private void btn_teste_Clicked(object sender, EventArgs e)
    {
		List<pedagio> valores = App.Db.GetAll();

        Console.WriteLine();
    }
}