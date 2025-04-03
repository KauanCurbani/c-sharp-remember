public class SendMessageClient {
    private readonly SendMessageInterface _sendMessageInterface;

    public SendMessageClient(SendMessageInterface sendMessageInterface)
    {
        _sendMessageInterface = sendMessageInterface;
    }

    public void Send(string message)
    {
        _sendMessageInterface.SendMessage(message);
    }
}