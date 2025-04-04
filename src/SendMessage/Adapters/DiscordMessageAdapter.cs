namespace MeuProjeto.SendMessage.Adapters;

public class DiscordMessageAdapter(bool? throws): SendMessageInterface
{
    public override async Task<string> SendMessage(string message)
    {
        if (throws == true)
        {
            throw new Exception("Simulated exception in DiscordMessageAdapter");
        }
        await Task.Delay(100); // Simulate async work
        Console.WriteLine($"Sending message to Discord: {message}");
        return message;
    }
}