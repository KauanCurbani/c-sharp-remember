using MeuProjeto.send_messages;
using MeuProjeto.send_messages.adapters;
using MeuProjeto.send_messages.decorators;
using MeuProjeto.send_messages.observers;

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