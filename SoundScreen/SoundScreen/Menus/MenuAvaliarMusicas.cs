
using SoundScreen.Models;
using System.Globalization;

namespace SoundScreen.Menus;

internal class MenuAvaliarMusicas : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //Chamada da classe base
        base.Executar(bandasRegistradas);
        ExibeTituloOpcao("Avalie a música");

        Console.Write("Digite o nome da banda que à música pertence: ");
        string nomeDaBanda = Console.ReadLine()!;
        //Verifica se a banda está no dicionário
        if(Banda.Contains(bandasRegistradas, nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"A banda {nomeDaBanda} foi encotrada com sucesso!\n");
            Console.Write("Agora digite o nome do álbum pertence: ");
            string tituloDoAlbum = Console.ReadLine()!;
            //Verifica se o álbum já existe na banda
            if(banda.Albuns.Any(a => a.Nome.Equals(tituloDoAlbum)))
            {
                Console.WriteLine($"O álbum {tituloDoAlbum} foi encontrado com sucesso!");
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloDoAlbum));
                Console.Write("\nDigite o nome da música que deseja avaliar: ");
                string nomeDaMusica = Console.ReadLine()!;

                //Verifica se a música já existe no álbum
                if(album.Musicas.Any(m => m.Nome.Equals(nomeDaMusica)))
                {
                    Console.Write($"Digite sua nota para a música {nomeDaMusica}: ");
                    //Converte a nota com o Parse da avaliação
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                    Musicas musica = album.Musicas.First(m => m.Nome.Equals(nomeDaMusica));
                    musica.AdicionarNota(nota);
                    Console.WriteLine($"\nA nota {nota.Nota} foi adicionada com sucesso para à música {nomeDaMusica}");
                    Thread.Sleep(2500);
                    Console.Clear();

                }
                else
                {
                    Console.WriteLine($"A música {nomeDaMusica} não foi encontrada no banco de dados!");
                    Console.WriteLine("Digite um tecla para voltar ao menu inicial:");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine($"O álbum {tituloDoAlbum} não foi encotrado no banco de dados!");
                Console.Write("Digite uma tecla para voltar ao menu inicial:");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada no banco de dados!");
            Console.Write("Digite uma tecla para voltar ao menu inicial: ");
            Console.ReadKey();
            Console.Clear();
        }
    }
    
}
