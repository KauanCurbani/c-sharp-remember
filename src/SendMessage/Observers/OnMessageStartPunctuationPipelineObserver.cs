namespace MeuProjeto.send_messages.observers;

public class OnMessageStartPunctuationPipelineObserver: ObserverInterface
{
    public void Call(string messageSent)
    {
        Console.WriteLine($"OnMessageStartPunctuationPipelineObserver called: {messageSent}");
    }
}