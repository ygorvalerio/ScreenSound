//Screen Sound

Musica musica1 = new Musica();

musica1.Nome = "Losing My Religion";
musica1.Artista = "R.E.M";
musica1.Duracao = 260;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);


Musica musica2 = new Musica();
musica2.Nome = "Wind of Change";
musica2.Artista = "Scorpions";
musica2.Duracao = 240;
musica2.Disponivel = false;
Console.WriteLine(musica2.DescricaoResumida);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();