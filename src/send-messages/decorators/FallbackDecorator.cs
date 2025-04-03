public class FallbackDecorator: SendMessageInterface
{
    private readonly SendMessageInterface _sendMessageInterface;
    private readonly SendMessageInterface _fallbackSendMessageInterface;

    public FallbackDecorator(SendMessageInterface sendMessageInterface, SendMessageInterface fallbackSendMessageInterface)
    {
        _sendMessageInterface = sendMessageInterface;
        _fallbackSendMessageInterface = fallbackSendMessageInterface;
    }

    public override void SendMessage(string message)
    {
        try
        {
            _sendMessageInterface.SendMessage(message);
        }
        catch (Exception)
        {
            _fallbackSendMessageInterface.SendMessage(message);
        }
    }
}