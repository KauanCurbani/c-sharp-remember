namespace MeuProjeto.send_messages.observers;

public class OnMessageVerifyContentObserver: ObserverInterface
{
    public void Call(string messageSent)
    {
        Console.WriteLine($"OnMessageVerifyContentObserver called: {messageSent}");
    }
}