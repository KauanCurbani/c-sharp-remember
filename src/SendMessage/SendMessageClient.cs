namespace MeuProjeto.SendMessage;

public class SendMessageClient(SendMessageInterface sendMessageInterface)
{
    private readonly List<IObserver> _observers = [];

    public async Task Send(string message)
    {
        var messageSent = await sendMessageInterface.SendMessage(message);
        Console.WriteLine("");
        NotifyObservers(messageSent);
    }

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    private void NotifyObservers(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Call(message);
        }
    }
}