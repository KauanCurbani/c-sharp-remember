namespace MeuProjeto.send_messages.decorators;

public class UppercaseMessageDecorator(SendMessageInterface sendMessageInterface) : SendMessageInterface
{
    public override void SendMessage(string message)
    {
        string upperCaseMessage = message.ToUpper();
        sendMessageInterface.SendMessage(upperCaseMessage);
    }
}