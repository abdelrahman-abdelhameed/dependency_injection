
using DependencyInjection;

// 0 
var service = new DoSomeWorkService();
var consumer = new ServiceConsumer(service);


//1
// var service = (DoSomeWorkService) Activator.CreateInstance(typeof(DoSomeWorkService));
// var consumer = (ServiceConsumer) Activator.CreateInstance(typeof(ServiceConsumer), service);

// 3 
 //var container = new DependencyContainer();
 // container.Register<DoSomeWorkService>();
 // container.Register<ServiceConsumer>();
 // container.Register<TextProvidorService>(); // 4
 
 // container.RegisterSingleton<DoSomeWorkService>();
 // container.RegisterSingleton<ServiceConsumer>();
 // container.RegisterSingleton<TextProvidorService>();
 
 //
 // container.RegisterTransient<DoSomeWorkService>();
 // container.RegisterTransient<ServiceConsumer>();
 // container.RegisterTransient<TextProvidorService>();
 //
// var resolver = new DependencyResolver(container);
//
//  var service = resolver.Resolve<DoSomeWorkService>();
//  var consumer = resolver.Resolve<ServiceConsumer>();
//  var consumer1 = resolver.Resolve<ServiceConsumer>();
//  var consumer2 = resolver.Resolve<ServiceConsumer>();
  
 
 

// result 
 consumer.Print("This is a message from the consumer.");
// consumer1.Print("This is a message from the consumer.");
// consumer2.Print("This is a message from the consumer.");
//
// service.Print("This is a message from the service.");



Console.ReadLine();












// types of  Dependency Injection
// Constructor Injection
// Property Injection
// Method Injection
// Parameter Injection
// Interface Injection
