using System.Diagnostics.Contracts;

namespace DependencyInjection;

public class DependencyContainer
{
    private List<Type> dependencies;

    public DependencyContainer()
    {
        dependencies = new List<Type>();
    }
    
    // object will added here as a type 
    public void Register<T>()
    {
      
        dependencies.Add(typeof(T));
    }
    
    
    // get by name because we  stroed the type in  a list of types and  we need to search in it by name
    
    public Type GetDependency(Type type)
    {
       return  dependencies.First(d => d.Name == type.Name);
        
    }
   
    
   
}


// 30


// class can be a type 
//function can be a type
// interface can be a type
// enum can be a type
// struct can be a type


