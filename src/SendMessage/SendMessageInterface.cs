namespace MeuProjeto.send_messages;

public abstract class SendMessageInterface
{
    public abstract Task<string> SendMessage(string message);
}