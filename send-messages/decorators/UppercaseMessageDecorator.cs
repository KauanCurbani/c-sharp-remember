public class UppercaseMessageDecorator : SendMessageInterface
{
    private readonly SendMessageInterface _sendMessageInterface;

    public UppercaseMessageDecorator(SendMessageInterface sendMessageInterface)
    {
        _sendMessageInterface = sendMessageInterface;
    }

    public override void SendMessage(string message)
    {
        string upperCaseMessage = message.ToUpper();
        _sendMessageInterface.SendMessage(upperCaseMessage);
    }
}