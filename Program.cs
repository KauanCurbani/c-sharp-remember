using MeuProjeto.send_messages;
using MeuProjeto.send_messages.adapters;
using MeuProjeto.send_messages.decorators;

namespace MeuProjeto;

internal abstract class MeuProjeto
{
    private static void Main()
    {
        SendMessageInterface messageProvider = new DiscordMessageAdapter(true);
        messageProvider = new UppercaseMessageDecorator(messageProvider);
        messageProvider = new FallbackDecorator(messageProvider, new WhatsAppAdapter());

        SendMessageClient sendMessageClient = new SendMessageClient(messageProvider);
        sendMessageClient.Send("Hello!!");
    }
}