namespace PrimaApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("TABELLINE!");
                Console.WriteLine("Per salvare sul disco la tua tabellina usa il seguente schema");
                Console.WriteLine("applicazione.exe [tabellina] [ripetizioni]");
                Console.WriteLine("es.: c:\\>applicazione.exe 2 10");
            } else
            {
                int tabellina = int.Parse(args[0]);
                int ripetizioni = int.Parse(args[1]);
                for(int i=0; i < ripetizioni; i++)
                {
                    int risultato = tabellina * i;
                    Console.WriteLine($"{tabellina} x {i} = {risultato}");
                }
            }
            

        }
    }
}