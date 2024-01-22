namespace SoundScreen.Models;

internal class Musicas
{
    //lista de avaliações
    private List<Avaliacao> notas = new ();
    //Construtor que garante que as músicas tenham uma banda e um nome
    public Musicas(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome {  get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { set; get; }
    //Propriedade da média, onde é verificado se existe conteúdo na lista de avaliações
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    //Exibe detalhes da música
    public void ExibeFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");

        if (Disponivel)
        {
            Console.WriteLine($"A {Nome} está disponível!\n");
        }else
        { 
            Console.WriteLine($"A {Nome} não está disponível!\n"); 
        }

    }
    //Adiciona nota
    public void AdicionarNota(Avaliacao nota) 
    {
        notas.Add(nota);
    }

}