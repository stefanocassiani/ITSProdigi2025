using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {
        string rootFolder = "C:\\testITS";

        HttpListener server = new HttpListener();
        server.Prefixes.Add("http://localhost:8080/");
        server.Start();
        Console.WriteLine("Server in ascolto...");
        while (true)
        {
            // attendo una chiamata
            HttpListenerContext chiamata = server.GetContext();
            // leggo la richiesta
            HttpListenerRequest cassa = chiamata.Request;
            Console.WriteLine($"Chiamata in ingresso per {cassa.RawUrl}");
            // ne prendo il microsofono per parlare
            HttpListenerResponse microfono = chiamata.Response;
            // decido cosa dire
            // capendo se il file esiste
            string nomeFile = rootFolder + cassa.RawUrl.Replace("/", "\\");
            string rispostaStandard = $"Hai chiesto di vedere il file {nomeFile}";
            if (File.Exists(nomeFile))
            {
                // e se esiste caricando il suo contenuto nella risposta da inviare
                rispostaStandard = File.ReadAllText(nomeFile);
            }            
            // lo converto in impulsi
            byte[] impulsi = System.Text.Encoding.UTF8.GetBytes(rispostaStandard);
            Console.WriteLine("messaggio convertito in impulsi");
            // e lo spedisco al mio interlocutore
            microfono.OutputStream.Write(impulsi, 0, impulsi.Length);
            // prima di riagganciare il telefono
            microfono.OutputStream.Close();
        }
    }
}