namespace MeuProjeto.send_messages.adapters;

public class WhatsAppAdapter: SendMessageInterface
{
    public override void SendMessage(string message)
    {
        Console.WriteLine($"Sending message to Whatsapp: {message}");
    }
}