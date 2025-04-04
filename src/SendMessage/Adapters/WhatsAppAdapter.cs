namespace MeuProjeto.SendMessage.Adapters;

public class WhatsAppAdapter: SendMessageInterface
{
    public override async Task<string> SendMessage(string message)
    {
        await Task.Delay(100); // Simulate async work
        Console.WriteLine($"Sending message to Whatsapp: {message}");
        return message;
    }
}