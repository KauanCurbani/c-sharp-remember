namespace MeuProjeto.SendMessage.Decorators;

public class TranslateDecorator(SendMessageInterface provider) : SendMessageInterface
{
    public override async Task<string> SendMessage(string message)
    {
        var translatedMessage = Translate(message);
        return await provider.SendMessage(translatedMessage);
    }

    private string Translate(string message)
    {
        var dictionary = new Dictionary<string, string>()
        {
            { "Hello", "Olá" },
            { "nice", "bom" },
            { "developer", "desenvolvedor" },
        };

        var translatedMessage = message;
        foreach (var word in dictionary)
        {
            translatedMessage = translatedMessage.Replace(word.Key, word.Value);
        }

        return translatedMessage;
    }
}