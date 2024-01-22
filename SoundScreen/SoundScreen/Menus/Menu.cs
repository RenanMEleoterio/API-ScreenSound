using SoundScreen.Models;
namespace SoundScreen.Menus;

internal class Menu
{
    //Faz a exibição personalizada do titulo do menu
    public void ExibeTituloOpcao(string titulo)
    {
        int quantidadeCaracteres = titulo.Length;
        string negrito = string.Empty.PadLeft(quantidadeCaracteres, '*');

        Console.WriteLine(negrito);
        Console.WriteLine(titulo);
        Console.WriteLine(negrito + "\n");
    }
    //Classe interna onde pode ser sobreescrito o menu
    internal virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }
}
