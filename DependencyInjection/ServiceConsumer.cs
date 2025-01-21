namespace DependencyInjection;

public class ServiceConsumer
{
    private readonly DoSomeWorkService _service;

    public ServiceConsumer(DoSomeWorkService service)
    {
        _service = service;
    }
    
    
    public void Print(string message)
    {
        _service.Print(message);
    }
    
}