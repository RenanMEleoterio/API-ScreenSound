using SoundScreen.Models;

namespace SoundScreen.Menus;

internal class MenuAvaliarBandas : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //Chamada da classe base
        base.Executar(bandasRegistradas);
        //pede o nome da banda
        //verifica se a banda existe
        //pede nota da banda
        ExibeTituloOpcao("Avalie a banda");
        Console.Write("Digite o nome da banda que quer avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        //Verifica existência da banda

        if (Banda.Contains(bandasRegistradas, nomeDaBanda))
        {
            Console.WriteLine($"A banda {nomeDaBanda} foi encontrada com sucesso!");
            Console.Write("\nDigite a nota: ");
            //Converte a nota com o Parse da avaliação
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);

            Banda banda = bandasRegistradas[nomeDaBanda];
            //Adiciona a nota
            banda.AdicionarNota(nota);
            Thread.Sleep(2500);
            Console.WriteLine($"Sua nota {nota.Nota} foi registrada para a banda {nomeDaBanda} com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada em nosso banco de dados!");
            Console.WriteLine("\nDigite qualquer tecla para voltar ao menu anterior");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
