Episodio ep1 = new("Tecnicas de facilitação", 1, 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Ygor");


Episodio ep2 = new("Tecnicas", 1, 45);
ep2.AdicionarConvidados("Larissa");
ep2.AdicionarConvidados("Gabriel");

Podcats podcats = new("Podcast Especial", "Daniel");
podcats.AdicionarEpisodio(ep1);
podcats.AdicionarEpisodio(ep2);
podcats.ExibirDetalhes();
