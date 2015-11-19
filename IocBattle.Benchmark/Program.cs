namespace IocBattle.Benchmark
{
  using System;
  using Tests;

  internal class Program
  {
    private static void Main()
    {
      var containers = new IContainer[]
      {
        new NewContainer(),
        new DynamoAutoContainer(),
        new AutoFacLambdaContainer(),
        new AutoFacContainer(),
        new StructureMapContainer(),
        new SimpleInjectorContainer(),
        new UnityContainer(),
        //new NinjectContainer(),
        new WindsorContainer()
      };

      foreach (var container in containers)
      {
        new BenchEngine(container).Start();
      }

      Console.Read();
    }
  }
}