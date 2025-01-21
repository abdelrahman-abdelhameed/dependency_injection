namespace DependencyInjection;


public class DoSomeWorkService
{
    private readonly TextProvidorService _textProvidorService;

    public DoSomeWorkService(TextProvidorService textProvidorService)
    {
        _textProvidorService = textProvidorService;
    }
    public void Print(string message)
    {
        Console.WriteLine($"this is a message from the service: {_textProvidorService.TextMessage()}");
        Console.WriteLine($"paramter message  {message}");
    } 
}
// public class DoSomeWorkService
// {
//     public void Print(string message)
//     {
//         Console.WriteLine(message);
//     }
// }