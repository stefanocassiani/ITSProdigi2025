using Stradario.Strutture;
using System.Globalization;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Stradario
{
    public class Nominatim
    {
        public static void RecuperaHTTP(Nodo nodo)
        {
            string url = $"https://nominatim.openstreetmap.org/search?q={nodo.nome}&format=jsonv2&limit=1";
            HttpClient client = new HttpClient();
            HttpRequestMessage richiesta = new HttpRequestMessage(HttpMethod.Get, url);
            richiesta.Headers.Add("User-Agent", "Other");
            HttpResponseMessage risposta = client.Send(richiesta);
            if (risposta.IsSuccessStatusCode)
            {
                string json = risposta.Content.ReadAsStringAsync().Result;
                List<Luogo> luoghi = JsonSerializer.Deserialize<List<Luogo>>(json);
            }
        }

        public static void RecuperaWeb(Nodo nodo)
        {
            string url = $"https://nominatim.openstreetmap.org/search?q={nodo.nome}&format=jsonv2&limit=1";
            WebClient client = new WebClient();
            client.Headers.Add("User-Agent: Other");
            string json = client.DownloadString(url);
            if(json != string.Empty)
            {
                List<Luogo> luoghi = JsonSerializer.Deserialize<List<Luogo>>(json);
            }
        }

        public class Luogo
        {
            [JsonPropertyName("name")]
            public string Nome { get; set; } = string.Empty;
            [JsonPropertyName("lat")]
            public string Lat { get; set; }
            [JsonPropertyName("lon")]
            public string Lon { get; set; }
            [JsonIgnore]
            public double Y => double.Parse(Lat, CultureInfo.InvariantCulture);
            [JsonIgnore]
            public double X => double.Parse(Lon, CultureInfo.InvariantCulture);
            public override string ToString() => Nome;
        }
    }
}
