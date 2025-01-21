namespace DependencyInjection;

public enum DependencyLifetime
{
    Singleton = 0, // single instance
    Transient = 1 // fresh instance every time
}