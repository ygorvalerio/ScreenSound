﻿class Musica


{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get;}
    public Banda Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida => $"A música {Nome} pertenece à banda {Artista}";
                
        
            
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: "+ Nome);
        Console.WriteLine($"Artista: " + Artista.Nome);
        Console.WriteLine($"Duração: " + Duracao);

        if (Disponivel)
        {
            Console.WriteLine($"Disponivel no Plano!");
        }
        else {
            Console.WriteLine($"Adquira o Plano Plus+");
        }
    }

}