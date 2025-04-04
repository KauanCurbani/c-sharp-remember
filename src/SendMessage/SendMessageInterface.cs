namespace MeuProjeto.SendMessage;

public abstract class SendMessageInterface
{
    public abstract Task<string> SendMessage(string message);
}