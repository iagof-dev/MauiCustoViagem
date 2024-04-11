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
			await DisplayAlert("Sucesso!", "Pedagio foi adicionado", "Ok");
        }
        catch (Exception ex)
		{
			await DisplayAlert("Erro", ex.Message, "Ok");
        }
    }

    private async void btn_teste_Clicked(object sender, EventArgs e)
    {
		List<pedagio> valores = await App.Db.GetAll();

		string Lista = "";

        foreach (pedagio p in valores)
        {
			Lista += $"local: {p.local}\nvalor: {p.valor}\n";
        }
		await DisplayAlert("Teste", Lista, "Ok");
    }
}