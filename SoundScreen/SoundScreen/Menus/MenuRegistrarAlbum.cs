using SoundScreen.Models;

namespace SoundScreen.Menus;

internal class MenuRegistrarAlbum : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //Chamada da classe base
        base.Executar(bandasRegistradas);
        ExibeTituloOpcao("Registro de álbuns");
        Console.Write("Digite o nome da banda para qual deseja adicionar um álbum: ");
        string nomeDaBanda = Console.ReadLine()!;
        //Verifica a existência da banda
        if (Banda.Contains(bandasRegistradas, nomeDaBanda))
        {
            Console.WriteLine($"A banda {nomeDaBanda} foi encontrada com sucesso!");
            Console.Write("Digite o nome do álbum que vai ser adicionado: ");
            string tituloDoAlbum = Console.ReadLine()!;
            Banda banda = bandasRegistradas[nomeDaBanda];
            //Verifica a existência do álbum
            if(banda.Albuns.Any(a => a.Nome.Equals(tituloDoAlbum)))
            {
                Console.WriteLine($"O álbum {tituloDoAlbum} já está cadastrado no banco de dados!");
                Console.Write("Digite um tecla para voltar ao menu inicial:");
                Console.ReadKey();  
                Console.Clear();
            }
            else
            {
                banda.AdicionaAlbum(new Album(tituloDoAlbum));
                Console.WriteLine($"O álbum {tituloDoAlbum} foi adicinado à banda {nomeDaBanda} com sucesso!");
                Thread.Sleep(2500);
                Console.Clear();
            }
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
