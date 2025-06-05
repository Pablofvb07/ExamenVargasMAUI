namespace ExamenVargasMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnVerChisteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaChistes());
        }
    }

}
