namespace DependencyInjection;

public class Dependancy
{
    public Dependancy( Type type, DependencyLifetime dependencyLifetime)
    {
        Type = type;
        DependencyLifetime = dependencyLifetime;
    }
    
    public Type Type { get; set; }
    public DependencyLifetime DependencyLifetime { get; set; }

    public object? Implemention { get; set; }

    public bool IsImplemented { get; set; }
    
    public void SetImplemention(object implemention)
    {
        Implemention = implemention;
        IsImplemented = true;
    }
}