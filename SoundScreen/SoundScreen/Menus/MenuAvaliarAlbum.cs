
using SoundScreen.Models;

namespace SoundScreen.Menus;

internal class MenuAvaliarAlbum : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //Chamada da classe base
        base.Executar(bandasRegistradas);

        ExibeTituloOpcao("Avalie o Álbum");
        Console.Write("Digite o nome da banda que quer avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        //Verifica existência da banda
        if (Banda.Contains(bandasRegistradas, nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"A banda {nomeDaBanda} foi encontrada com sucesso!");
            Console.Write("\nAgora digite o nome do álbum: ");
            string tituloDoAlbum = Console.ReadLine()!;
            //Verifica existência do álbum
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloDoAlbum)))
            {
                Console.WriteLine($"O álbum {tituloDoAlbum} foi encontrado com sucesso!");
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloDoAlbum));
                Console.Write("\nDigite a nota: ");
                //Converte a nota com o Parse da avaliação
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                //Adiciona a nota ao álbun
                album.AdicionarNota(nota);
                Console.WriteLine($"Sua nota {nota.Nota} foi registrada para o álbum {tituloDoAlbum} com sucesso!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"O álbum {tituloDoAlbum} não foi encontrado em nosso banco de dados!");
                Console.WriteLine("\nDigite qualquer tecla para voltar ao menu anterior");
                Console.ReadKey();
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
