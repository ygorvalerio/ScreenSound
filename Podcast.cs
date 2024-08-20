using System.Security.Cryptography.X509Certificates;

class Podcats
{
    private List<Episodio> episodios = new();
    public Podcats(string nome, string hosts)
    {
        Nome = nome;
        Hosts = hosts;
    }

    public string Nome { get; }

    public string Hosts { get; }

    public int TotalEpisodios => episodios.Count;


    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Hosts} /n");

        foreach (Episodio episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($" /n/n Este podscast possui {TotalEpisodios} episodios.");


    }
}