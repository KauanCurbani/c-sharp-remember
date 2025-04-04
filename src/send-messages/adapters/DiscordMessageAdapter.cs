namespace MeuProjeto.send_messages.adapters;

public class DiscordMessageAdapter : SendMessageInterface
{
    private readonly bool? _throws;

    public DiscordMessageAdapter(bool? throws)
    {
        _throws = throws;
    }

    public override void SendMessage(string message)
    {
        if (_throws == true)
        {
            throw new Exception("Simulated exception in DiscordMessageAdapter");
        }

        Console.WriteLine($"Sending message to Discord: {message}");
    }
}