class Program
{

    static void Main()
    {
        SendMessageInterface _messageProvider = new DiscordMessageAdapter(true);
        _messageProvider = new UppercaseMessageDecorator(_messageProvider);
        _messageProvider = new FallbackDecorator(_messageProvider, new EmailMessageAdapter());

        SendMessageClient _sendMessageClient = new SendMessageClient(_messageProvider);
        _sendMessageClient.Send("Hello!!");
    }
}
