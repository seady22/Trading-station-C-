using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Integration.Mef;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using TradePlatform.MT4.Engine.Extension;
using TradePlatform.MT4.Engine.Model;

namespace TradePlatform.MT4.Engine
{
  public class Bootstrapper
  {
    public static void Initialize()
    {
      var containerBuilder = new ContainerBuilder();
      RegistrationExtensions.RegisterType<TaskEvaluator>(containerBuilder);
      RegistrationExtensions.RegisterType<TaskTimer>(containerBuilder);
      var directoryCatalog = new DirectoryCatalog(Environment.CurrentDirectory);
      RegistrationExtensions.RegisterComposablePartCatalog(containerBuilder, (ComposablePartCatalog) directoryCatalog, new Service[1]
      {
        (Service) new TypedService(typeof (ITask))
      });
      ((IRegistrationBuilder<IEnumerable<TaskInfo>, SimpleActivatorData, SingleRegistrationStyle>) RegistrationExtensions.Register<IEnumerable<TaskInfo>>(containerBuilder, (Func<IComponentContext, M0>) (c => Enumerable.Select<Export, TaskInfo>(RegistrationExtensions.ResolveExports<ITask>((IComponentContext) ResolutionExtensions.Resolve<IComponentContext>(c)), (Func<Export, TaskInfo>) (e => new TaskInfo(TimeSpan.FromMilliseconds((double) (int) e.Metadata["MinInterval"]), (string) e.Metadata["Name"], (Func<ITask>) (() => (ITask) e.Value))))))).As<IEnumerable<TaskInfo>>();
      using (IContainer icontainer = containerBuilder.Build((ContainerBuildOptions) 0))
        ((TaskTimer) ResolutionExtensions.Resolve<TaskTimer>((IComponentContext) icontainer)).Run();
    }
  }
}
