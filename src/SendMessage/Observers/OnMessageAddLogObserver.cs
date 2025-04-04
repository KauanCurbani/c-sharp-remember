namespace MeuProjeto.SendMessage.Observers;

public class OnMessageAddLogObserver: IObserver
{
    public void Call(string messageSent)
    {
       Console.WriteLine($"OnMessageAddLogObserver called: {messageSent}");
    }
}