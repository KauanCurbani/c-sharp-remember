namespace MeuProjeto.SendMessage.Observers;

public class OnMessageStartPunctuationPipelineObserver: IObserver
{
    public void Call(string messageSent)
    {
        Console.WriteLine($"OnMessageStartPunctuationPipelineObserver called: {messageSent}");
    }
}