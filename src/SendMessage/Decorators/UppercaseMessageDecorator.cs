namespace MeuProjeto.SendMessage.Decorators;

public class UppercaseMessageDecorator(SendMessageInterface sendMessageInterface) : SendMessageInterface
{
    public override async Task<string> SendMessage(string message)
    {
        string upperCaseMessage = message.ToUpper();
        return await sendMessageInterface.SendMessage(upperCaseMessage);
    }
}