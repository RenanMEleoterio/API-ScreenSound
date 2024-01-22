namespace SoundScreen.Models;


internal class Banda : IAvaliavel
{
    //Listas de álbuns e de avaliação para cada banda
    private List<Album> albuns = new();
    private List<Avaliacao> notas = new();

    //Construtor para garantir que a banda tenha nome
    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    //Propriedade da média, onde se a note for menor que 0 ela receba 0
    public double Media
    {
        get
        {
            //Verifica a lista para saber se há indices na nota. Se não hover a média recebe 0 se houver há o cálculo da média com a expressão lambda que cada av(avalição) use nota
            if (notas.Count == 0) return 0;
            else return notas.Average(av => av.Nota);
        }
    }
    public string? Resumo { get; set; }
    // Modificando a propriedade Albuns para retornar IEnumerable<Album> onde não é possivel alterar o valor dos dados
    public IEnumerable<Album> Albuns => albuns;

    //Função para adicionar um álbum na lista
    public void AdicionaAlbum (Album album)
    {
        albuns.Add (album);
    }
    //Função para adicionar nota à lista
    public void AdicionarNota( Avaliacao nota)
    {
        notas.Add(nota);
    }

    //Exibe discografia da música
    public void ExibeDiscografia()
    {
        Console.WriteLine($"\nExibindo a discografia da banda {Nome}\n");

        if(albuns.Count == 0)
        {
            Console.WriteLine("Não há detalhes para serem exibidos\n");
        }
        else
        {
            foreach (var album in albuns)
            {
                Console.WriteLine($"Album: {album.Nome}");
                album.ExibirMusicasDoAlbum();
                Console.WriteLine($"A média das notas deste álbum é: {album.Media}\n"); 
            }
        }
    }

    //Método estático usado para verificar se a banda informada no parâmetro nome banda exite o dicionário bandasRegistradas
    public static bool Contains(Dictionary<string, Banda> bandasRegistradas,string nomeDaBanda)
    {
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}