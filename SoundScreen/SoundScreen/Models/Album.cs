namespace SoundScreen.Models;

internal class Album : IAvaliavel
{
    //Listas de músicas e avaliações
    private List<Musicas> musicas = new();
    private List<Avaliacao> notas = new();

    //Construtor para que o álbum tenha nome assim que instânciado
    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    //Duração do álbum, somando todas as durações das músicas
    public int Duracao => musicas.Sum(m => m.Duracao);
    public Genero? Genero { get; set; }
    //Pega a média das notas do álbum, se não houver notas a nota será 0
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    //Interfae para mostras as músicas como uma lista, invalidando a modificação de dados
    public IEnumerable<Musicas> Musicas => musicas;
    //Adiciona músicas
    public void AdicionarMusica (Musicas musica)
    {
        musicas.Add (musica);
    }
    //Adiciona nota
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add (nota);
    }
    //Mostras todas as músicas do álbum
    public void ExibirMusicasDoAlbum()
    {
        if (musicas.Count == 0)
        {
            Console.WriteLine("Não há musicas neste álbum!");
        }
        else
        {
            Console.WriteLine($"O álbum contém as seguntes músicas\n");

            foreach (var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome} -> Média das notas {musica.Media}");
            }

            Console.WriteLine($"Para ouvir o album completo você precisa de {Duracao} segundos");
        }

    }

}