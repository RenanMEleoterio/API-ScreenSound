using OpenAI_API;
using SoundScreen.Models;

namespace SoundScreen.Menus;

internal class MenuRegistroDeBandas : Menu
{
    internal override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //Chamada da classe base
        base.Executar(bandasRegistradas);
        ExibeTituloOpcao("Registro de bandas.");
        Console.Write("Digite o nome da banda: ");
        string nomeBanda = Console.ReadLine()!;
        //Verifica a existência da banda
        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.WriteLine("Não é possível adicionar esta banda pois ela já existe no banco de dados!");
            Console.Write("Digite uma tecla para voltar ao menu inicial:");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Banda banda = new(nomeBanda);
            bandasRegistradas.Add(nomeBanda, banda);
            Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
            var client = new OpenAIAPI("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");

            var chat = client.Chat.CreateConversation();
            chat.AppendSystemMessage($"Resuma a banda {nomeBanda} em um paragráfo. Adote um estilo informal");

            string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
            banda.Resumo = resposta;
            Console.Clear();
        }
    }
}
