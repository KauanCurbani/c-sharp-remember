namespace MeuProjeto.send_messages.decorators;

public class UppercaseMessageDecorator(SendMessageInterface sendMessageInterface) : SendMessageInterface
{
    public override async Task<string> SendMessage(string message)
    {
        string upperCaseMessage = message.ToUpper();
        return await sendMessageInterface.SendMessage(upperCaseMessage);
    }
}