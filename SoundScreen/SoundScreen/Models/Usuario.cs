/*
 * Só desenvolvimento, implementação não feita
 */
namespace SoundScreen.Models;
internal class Usuario
{
    //Construtor que exige o nome, idade e senha
    public Usuario(string nome, int idade, string senha)
    {
        Nome = nome;
        Idade = idade;
        Senha = senha;
    }

    public string Nome { get; set; }
    public int Idade { get; set; }  
    public string? Email { get; set; }
    public string Senha { get; }
    //Exibe mensagem de boa vindas
    public void BoasVindas()
    {
        Console.WriteLine($"Boas vindas {Nome} ao Sound Screen o melhor página de músicas.");

    }
}