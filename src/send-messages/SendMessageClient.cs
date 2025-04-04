namespace MeuProjeto.send_messages;

public class SendMessageClient(SendMessageInterface sendMessageInterface)
{
    public void Send(string message)
    {
        sendMessageInterface.SendMessage(message);
    }
}