/*
 * Só desenvolvimento, não foi implementada
 */
/*
 * Só desenvolvimento, implementação não feita
 */
namespace SoundScreen.Models;

internal class Playlists
{
    //Construtor que exige um nome para a playlist
    public Playlists(string nome)
    {
        Nome = nome;
    }

    //Lista de músicas na playlist
    private List<Musicas> musicas = new List<Musicas>();

    public string Nome { get; set; }

    public Genero? Tipo{ get; set; }

    //Adiciona músicas a playlist, verficando se já exite alguma música com o mesmo nome
    public void AdicionarMusicasAPlaylist(Musicas musica)
    {
        if (musicas.Any(m => m.Nome.Equals(musica.Nome)))
        {
            Console.WriteLine($"Está música já existe na playlist!");
            Console.Write("Digite um tecla para voltar ao menu inicial");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            musicas.Add(musica);
            Console.WriteLine($"A música {musica.Nome} foi adicionada com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }

    public void MostrarMusicasDaPlaylist()
    {
        foreach (var musica in musicas)
        {
            Console.WriteLine(musica.Nome);
        }

        Console.WriteLine($"Esta playlist tem {musicas.Count}");
    }

}