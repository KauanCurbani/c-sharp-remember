namespace MeuProjeto.SendMessage.Adapters;

public class EmailMessageAdapter : SendMessageInterface
{
    public override async Task<string> SendMessage(string message)
    {
        await Task.Delay(100); // Simulate async work
        Console.WriteLine($"Sending message to Email: {message}");
        return message;
    }
}