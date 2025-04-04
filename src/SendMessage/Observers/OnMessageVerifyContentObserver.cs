namespace MeuProjeto.SendMessage.Observers;

public class OnMessageVerifyContentObserver: IObserver
{
    public void Call(string messageSent)
    {
        Console.WriteLine($"OnMessageVerifyContentObserver called: {messageSent}");
    }
}