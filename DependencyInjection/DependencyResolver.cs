namespace DependencyInjection;

//0

// public class DependencyResolver
// {
//     private readonly DependencyContainer _container;
//
//     public DependencyResolver(DependencyContainer container)
//     {
//         _container = container;
//     }
//
//     public T Resolve<T>()
//     {
//         var dependency = _container.GetDependency(typeof(T));
//
//         var constructor = dependency.GetConstructors().Single();
//         var parameters = constructor.GetParameters().ToArray();
//         var parameterValues = new object[parameters.Length];
//
//         if (parameters.Length > 0)
//         {
//             for (int i = 0; i < parameters.Length; i++)
//             {
//                 var parameter = parameters[i];
//                 parameterValues[i] = Activator.CreateInstance(parameter.ParameterType);
//             }
//             
//             return (T) Activator.CreateInstance(dependency, parameterValues);
//
//             
//             
//         }
//
//
//         return (T) Activator.CreateInstance(dependency);
//     }
// }

// 1
// public class DependencyResolver
// {
//     private readonly DependencyContainer _container;
//
//     public DependencyResolver(DependencyContainer container)
//     {
//         _container = container;
//     }
//     
//     public T Resolve<T>()
//     {
//
//         return (T) Resolve(typeof(T));
//     }
//     
//     
//     public object Resolve(Type type)
//     {
//         var dependency = _container.GetDependency(type);
//         
//         var constructor = dependency.GetConstructors().Single();
//         var parameters = constructor.GetParameters().ToArray();
//         var parameterValues = new object[parameters.Length];
//
//         if (parameters.Length > 0)
//         {
//             for (int i = 0; i < parameters.Length; i++)
//             {
//                 var parameter = parameters[i];
//                 parameterValues[i] = Resolve(parameter.ParameterType);
//             }
//              
//             return Activator.CreateInstance(dependency, parameterValues);
//
//         }
//        
//         
//         return Activator.CreateInstance(dependency);
//     }
// }

//2  with DependencyLifetime
public class DependencyResolver
{
    private readonly DependencyContainer _container;

    public DependencyResolver(DependencyContainer container)
    {
        _container = container;
    }

    public T Resolve<T>()
    {
        return (T) Resolve(typeof(T));
    }


    public object? Resolve(Type type)
    {
        var dependency = _container.GetDependency(type);

        var constructor = dependency.Type.GetConstructors().Single();
        var parameters = constructor.GetParameters().ToArray();
        var parameterValues = new object?[parameters.Length];

        if (parameters.Length > 0)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                var parameter = parameters[i];
                parameterValues[i] = Resolve(parameter.ParameterType);
            }

            return CreateImplemention(dependency, t => Activator.CreateInstance(t, parameterValues));
        }

        return CreateImplemention(dependency, t => Activator.CreateInstance(t));
    }

    public object CreateImplemention(Dependancy dependency, Func<Type, object> factory)
    {
        if (dependency.IsImplemented)
        {
            return dependency.Implemention;
        }

        var implemention = factory(dependency.Type);

        if (dependency.DependencyLifetime == DependencyLifetime.Singleton)
        {
            dependency.SetImplemention(implemention);
        }

        return implemention;
    }
}