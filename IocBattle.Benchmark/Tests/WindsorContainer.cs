namespace IocBattle.Benchmark.Tests
{
  using Castle.MicroKernel.Registration;
  using Castle.Windsor;
  using Models;

  public class WindsorContainer : IContainer
  {
    private IWindsorContainer container;

    public string Name => "Castle Windsor";

    public T Resolve<T>()
      where T : class
    {
      return container.Resolve<T>();
    }

    public void SetupForSingletonTest()
    {
      container = new Castle.Windsor.WindsorContainer();
      container.Register(
        Component.For<IRepository>().ImplementedBy<Repository>().LifestyleSingleton(),
        Component.For<IAuthenticationService>().ImplementedBy<AuthenticationService>().LifestyleSingleton(),
        Component.For<UserController>().ImplementedBy<UserController>().LifestyleSingleton(),
        Component.For<IWebService>().ImplementedBy<WebService>().LifestyleSingleton(),
        Component.For<IAuthenticator>().ImplementedBy<Authenticator>().LifestyleSingleton(),
        Component.For<IStockQuote>().ImplementedBy<StockQuote>().LifestyleSingleton(),
        Component.For<IDatabase>().ImplementedBy<Database>().LifestyleSingleton(),
        Component.For<IErrorHandler>().ImplementedBy<ErrorHandler>().LifestyleSingleton(),
        Component.For<IService1>().ImplementedBy<Service1>().LifestyleSingleton(),
        Component.For<IService2>().ImplementedBy<Service2>().LifestyleSingleton(),
        Component.For<IService3>().ImplementedBy<Service3>().LifestyleSingleton(),
        Component.For<IService4>().ImplementedBy<Service4>().LifestyleSingleton(),
        Component.For<ILogger>().ImplementedBy<Logger>().LifestyleSingleton()
        );
    }

    public void SetupForTransientTest()
    {
      container = new Castle.Windsor.WindsorContainer();
      container.Register(
        Component.For<IRepository>().ImplementedBy<Repository>().LifestyleTransient(),
        Component.For<IAuthenticationService>().ImplementedBy<AuthenticationService>().LifestyleTransient(),
        Component.For<UserController>().ImplementedBy<UserController>().LifestyleTransient(),
        Component.For<IWebService>().ImplementedBy<WebService>().LifestyleTransient(),
        Component.For<IAuthenticator>().ImplementedBy<Authenticator>().LifestyleTransient(),
        Component.For<IStockQuote>().ImplementedBy<StockQuote>().LifestyleTransient(),
        Component.For<IDatabase>().ImplementedBy<Database>().LifestyleTransient(),
        Component.For<IErrorHandler>().ImplementedBy<ErrorHandler>().LifestyleTransient(),
        Component.For<IService1>().ImplementedBy<Service1>().LifestyleTransient(),
        Component.For<IService2>().ImplementedBy<Service2>().LifestyleTransient(),
        Component.For<IService3>().ImplementedBy<Service3>().LifestyleTransient(),
        Component.For<IService4>().ImplementedBy<Service4>().LifestyleTransient(),
        Component.For<ILogger>().ImplementedBy<Logger>().LifestyleTransient()
        );
    }
  }
}