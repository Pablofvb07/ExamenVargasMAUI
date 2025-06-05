using System.Net.Http.Json;

namespace ExamenVargasMAUI;
public partial class PaginaChistes : ContentPage
{
	public PaginaChistes()
	{
		InitializeComponent();
		CargarChiste();
	}
	private async void CargarChiste()
	{
		try
		{
			var client = new HttpClient();
			var chiste = await client.GetFromJsonAsync<Chiste>("https://official-joke-api.appspot.com/random_joke");
			if (chiste != null)
			{
				JokeLabel.Text = $"{chiste.Presentacion}\n \n {chiste.Remate}";

			}
		}
		catch
		{
			JokeLabel.Text = "No se pudo cargar el chiste";
		}
	}

	
	public class Chiste 
	{
		[System.Text.Json.Serialization.JsonPropertyName("setup") ]
		public string Presentacion { get; set;}
        [System.Text.Json.Serialization.JsonPropertyName("punchline")]
        public string Remate { get; set; }
    }

    private void OnOtroChisteClicked(object sender, EventArgs e)
    {
		CargarChiste();
    }
}