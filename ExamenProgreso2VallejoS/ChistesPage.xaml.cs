using Newtonsoft.Json;

namespace ExamenProgreso2VallejoS;

public partial class ChistesPage : ContentPage
{
    public ChistesPage()
    {
        InitializeComponent();
        ObtenerChiste(); 
    }

    private async void ObtenerChiste()
    {
        try
        {
            using HttpClient client = new HttpClient();
            string url = "https://official-joke-api.appspot.com/random_joke";
            var response = await client.GetStringAsync(url);

            var chiste = JsonConvert.DeserializeObject<Chiste>(response);
            ChisteLabel.Text = $"{chiste.Setup}\n\n{chiste.Punchline}";
        }
        catch (Exception ex)
        {
            ChisteLabel.Text = "No se pudo cargar el chiste. Verifica tu conexión.";
        }
    }

    private void OnOtroChisteClicked(object sender, EventArgs e)
    {
        ObtenerChiste();
    }

    public class Chiste
    {
        public string Type { get; set; }
        public string Setup { get; set; }
        public string Punchline { get; set; }
    }
}