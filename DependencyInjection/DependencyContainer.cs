using System.Diagnostics.Contracts;

namespace DependencyInjection;

public class DependencyContainer
{
   // private List<Type> dependencies;

    //0
    // public DependencyContainer()
    // {
    //     dependencies = new List<Type>();
    // }
    //
    // object will added here as a type 
    //0
    // public void Register<T>()
    // {
    //   
    //     dependencies.Add(typeof(T));
    // }
    //0
    // get by name because we  stroed the type in  a list of types and  we need to search in it by name
    // public Type GetDependency(Type type)
    // {
    //     return  dependencies.First(d => d.Name == type.Name);
    //     
    // }

    
    //1
    private List<Dependancy> dependencies;
    public DependencyContainer()
    {
        dependencies = new List<Dependancy>();
    }
    public Dependancy GetDependency(Type type)
    {
       return  dependencies.First(d => d.Type.Name == type.Name);
        
    }
    
    
    // 1
    public void RegisterSingleton<T>()
    {
        dependencies.Add(new Dependancy(typeof(T) , DependencyLifetime.Singleton));
    }
    
    
    public void RegisterTransient<T>()
    {
        dependencies.Add(new Dependancy(typeof(T) , DependencyLifetime.Transient));
    }
   
    
   
}


// 30


// class can be a type 
//function can be a type
// interface can be a type
// enum can be a type
// struct can be a type


