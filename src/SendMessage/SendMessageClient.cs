namespace MeuProjeto.send_messages;

public class SendMessageClient(SendMessageInterface sendMessageInterface)
{
    private readonly List<ObserverInterface> _observers = [];

    public async Task Send(string message)
    {
        var messageSent = await sendMessageInterface.SendMessage(message);
        Console.WriteLine("\n");
        NotifyObservers(messageSent);
    }

    public void AddObserver(ObserverInterface observer)
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