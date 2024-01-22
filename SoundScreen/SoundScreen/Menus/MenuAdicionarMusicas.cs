

using SoundScreen.Models;
using System;

namespace SoundScreen.Menus;

internal class MenuAdicionarMusicas : Menu
{
    //Classe que sobreescreve o menu
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //Chamada da classe base
        base.Executar(bandasRegistradas);
        ExibeTituloOpcao("Registrar músicas no álbum");
        Console.Write("Digite a banda para qual deseja adicionar uma música: ");
        string nomeDaBanda = Console.ReadLine()!;
        //Verifica se a banda já existe no banco de dados
        if (Banda.Contains(bandasRegistradas, nomeDaBanda)) 
        {
            Console.WriteLine($"A banda {nomeDaBanda} foi encontrada com sucesso!");
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("\nDigite o nome do álbum que a música vai ser adicionada: ");
            string tituloDoAlbum = Console.ReadLine()!;
            //Verifica existencia do álbum
            if(banda.Albuns.Any(a => a.Nome.Equals(tituloDoAlbum)))
            {
                Console.WriteLine($"O álbum {tituloDoAlbum} foi encontrado com sucesso!");
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloDoAlbum));
                Console.Write("Digite o nome da música que será adicionada: ");
                string nomeDaMusica = Console.ReadLine()!;
                //Verifica existência da música
                if (album.Musicas.Any(m => m.Nome.Equals(nomeDaMusica)))
                {
                    Console.WriteLine($"Está música já está cadastra no álbum {tituloDoAlbum}");
                    Console.Write("Digite um tecla para voltar ao menu inicial");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Musicas musica = new(banda, nomeDaMusica);
                    album.AdicionarMusica(musica);
                    Console.WriteLine($"A música {musica.Nome} foi adicionada ao {tituloDoAlbum} com sucesso!");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
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


