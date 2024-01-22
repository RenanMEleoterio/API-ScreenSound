using SoundScreen.Models;
namespace SoundScreen.Menus;

internal class MenuExibirBandas : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //Chama a classe base
        base.Executar(bandasRegistradas);
        //Exibe o nome das bandas pelas chaves do dicionário
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
            Console.WriteLine("\n");
        }
        Console.Write("\nDigite um tecla para sair");
        Console.ReadKey();
        Console.Clear();
    }
}
