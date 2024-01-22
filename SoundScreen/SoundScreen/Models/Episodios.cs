/*
 * Só desenvolvimento, implementação não feita
 */

namespace SoundScreen.Models;

internal class Episodios
{
    //Construtor
    public Episodios(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"{Ordem}-{Titulo} ({Duracao}) min - Convidado {string.Join(", ", Convidados)}";
    public string Titulo { get; }

    List<string> Convidados = new();

    public void AdicionarConvidados(string convidado)
    {
        Convidados.Add(convidado);
    }

}