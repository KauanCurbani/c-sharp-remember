namespace MeuProjeto.SendMessage;

public interface IObserver
{
    void Call(string messageSent);
}