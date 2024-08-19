class Banda
{
public string Nome { get; set; }

    private List<Album> albums = new List<Album>();

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
   
     
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Àlbum: {album.Nome} \nDuração: {album.DuracaoTotal} Minutos");
        }
    }



}