/*
 * Só desenvolvimento, implementação não feita
 */
namespace SoundScreen.Models;

internal class PodCast
{
    //Construtor que exige o nome do PodCast e o Host
    public PodCast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    //Lista de episódios
    private List<Episodios> Episodios = new();
    public string Nome { get; }
    public string Host { get; }
    
    //Verifica se o episódio já existe, se não adiciona ele a lista
    public void AdicionarEpisodio( Episodios episodio)
    {
        if(Episodios.Any(ep => ep.Titulo.Equals(episodio.Titulo))) 
        {
            Console.WriteLine("Esses episódio já existe");
        }
        else
        {
            Episodios.Add(episodio);
            Console.WriteLine("Episódio salvo com sucesso!");
            Thread.Sleep(1000);
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"PodCast: {Nome} apresentado por {Host}");

        //Itera todos os episódios dentro do podcast na ordem crescente do número definido da ordem da lista
        foreach(Episodios ep in Episodios.OrderBy(ep => ep.Ordem))
        {
            
            Console.WriteLine($"\n {ep.Resumo}");
        }

        Console.WriteLine($"O número total de episódios dele é {Episodios.Count}");

    }

}