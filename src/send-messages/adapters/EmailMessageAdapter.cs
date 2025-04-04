namespace MeuProjeto.send_messages.adapters;

public class EmailMessageAdapter : SendMessageInterface
{
    public override void SendMessage(string message)
    {
        Console.WriteLine($"Sending message to Email: {message}");
    }
}