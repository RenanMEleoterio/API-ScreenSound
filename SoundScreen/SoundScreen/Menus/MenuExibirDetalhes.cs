using SoundScreen.Models;

namespace SoundScreen.Menus;

internal class MenuExibirDetalhes : Menu
{
    
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //Chamada da classe base
        base.Executar(bandasRegistradas);
        ExibeTituloOpcao("Exibindo média das bandas");
        Console.Write("Digite o nome da banda que quer ver os detalhes: ");
        string nomeDaBanda = Console.ReadLine()!;
        //Verifica existência da banda
        if (Banda.Contains(bandasRegistradas, nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            //Pega a média das notas da banda
            double media = banda.Media;
            Console.WriteLine("\n" + banda.Resumo);
            Console.WriteLine($"\nA média da banda {nomeDaBanda} foi {media.ToString("N2")}.");
            //Chama a função para exibir discografia da banda
            banda.ExibeDiscografia();
            Console.WriteLine("Digite um tecla para voltar ao menu inicial");
            Console.ReadKey();
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encotrada em nosso banco de dados!");
            Console.WriteLine("Digite um tecla para voltar ao menu inicial.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
