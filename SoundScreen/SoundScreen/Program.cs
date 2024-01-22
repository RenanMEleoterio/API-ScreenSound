//Programa Screen Sound produzido no curso Alura

using SoundScreen.Menus;
using SoundScreen.Models;

//Bandas criadas para ter um exemplo funcional
Banda bandaLinkinPark = new("Linkin Park");
bandaLinkinPark.AdicionarNota( new Avaliacao(10));
bandaLinkinPark.AdicionarNota(new Avaliacao(9));
bandaLinkinPark.AdicionarNota(new Avaliacao(9));

Banda bandaRZO = new("RZO");

string mensagemDeBoasVindas = "Seja bem vindo ao nosso programa!";
//Instânciação do dicionário de bandas
Dictionary<string, Banda> bandasRegistradas = new ();
bandasRegistradas.Add(bandaLinkinPark.Nome, bandaLinkinPark);
bandasRegistradas.Add(bandaRZO.Nome, bandaRZO);

//Instânciação do dicionário de menus do sistema
Dictionary<int, Menu> opcoesDosMenus = new();
opcoesDosMenus.Add(1, new MenuRegistroDeBandas());
opcoesDosMenus.Add(2, new MenuRegistrarAlbum());
opcoesDosMenus.Add(3, new MenuAdicionarMusicas());
opcoesDosMenus.Add(4, new MenuAvaliarBandas());
opcoesDosMenus.Add(5, new MenuAvaliarAlbum());
opcoesDosMenus.Add(6, new MenuAvaliarMusicas());
opcoesDosMenus.Add(7, new MenuExibirBandas());
opcoesDosMenus.Add(8, new MenuExibirDetalhes());
opcoesDosMenus.Add(0, new MenuSair());

//Imprime a logo do programa
void ExibeLogo()
{
    Console.WriteLine(@"   
        █████████████████████████████████████████████████████████████████████████
        █─▄▄▄▄█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀███─▄▄▄▄█─▄▄▄─█▄─▄▄▀█▄─▄▄─█▄─▄▄─█▄─▀█▄─▄█
        █▄▄▄▄─█─██─██─██─███─█▄▀─███─██─███▄▄▄▄─█─███▀██─▄─▄██─▄█▀██─▄█▀██─█▄▀─██
        ▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀
    ");
    Console.WriteLine("\n" + mensagemDeBoasVindas);

}

//Exibe as descrições dos menus e colhe qual opção escolhida
void ExibeMenu()
{
    ExibeLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para adicionar um álbum à banda");
    Console.WriteLine("Digite 3 para adicionar uma música para o álbum");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para avaliar uma música");
    Console.WriteLine("Digite 7 para ver todas as banda registradas no sistema");
    Console.WriteLine("Digite 8 para exibir os dados da banda");
    Console.WriteLine("Digite 0 para sair do menu");

    Console.Write("\nDigite sua escolha: ");
    bool opcaoValida = int.TryParse(Console.ReadLine()!, out int opcaoEscolhida);

    if (opcaoValida)
    {
        if (opcoesDosMenus.ContainsKey(opcaoEscolhida))
        {
            Menu menuExecutado = opcoesDosMenus[opcaoEscolhida];
            menuExecutado.Executar(bandasRegistradas);

            if (opcaoEscolhida > 0) ExibeMenu();

        }
        else Console.WriteLine("Opção inválida!");
    }
    else Console.WriteLine("Letras não são permitadas nesse menu!");

}
//Chamada da função
ExibeMenu();

