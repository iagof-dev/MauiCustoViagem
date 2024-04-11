namespace MauiCustoViagem
{
    public partial class MainPage : ContentPage
    {
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

            Navigation.PushAsync(new Views.calcularViagem());
        }
    }

}
