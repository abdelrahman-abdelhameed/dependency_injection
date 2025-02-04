namespace DependencyInjection;

public class TextProvidorService
{
    int random = 0;
    public TextProvidorService()
    {
        random = new Random().Next();
    }
    public string  TextMessage()
    {
        return $"this is a text message #{random}";
    }
}