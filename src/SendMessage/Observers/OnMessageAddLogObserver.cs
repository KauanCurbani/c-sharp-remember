namespace MeuProjeto.send_messages.observers;

public class OnMessageAddLogObserver: ObserverInterface
{
    public void Call(string messageSent)
    {
       Console.WriteLine($"OnMessageAddLogObserver called: {messageSent}");
    }
}