using MeuProjeto.SendMessage;
using MeuProjeto.SendMessage.Adapters;
using MeuProjeto.SendMessage.Decorators;
using MeuProjeto.SendMessage.Observers;

namespace MeuProjeto;

internal abstract class MeuProjeto
{
    private static async Task Main()
    {
        SendMessageInterface messageProvider = new DiscordMessageAdapter(true);
        messageProvider = new FallbackDecorator(messageProvider, new WhatsAppAdapter());
        messageProvider = new UppercaseMessageDecorator(messageProvider);
        messageProvider = new TranslateDecorator(messageProvider);
        
        var sendMessageClient = new SendMessageClient(messageProvider);
        
        sendMessageClient.AddObserver(new OnMessageAddLogObserver());
        sendMessageClient.AddObserver(new OnMessageVerifyContentObserver());
        sendMessageClient.AddObserver(new OnMessageStartPunctuationPipelineObserver());
        
        await sendMessageClient.Send("nice developer!!");
    }
}