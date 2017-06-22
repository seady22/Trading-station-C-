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
      ContainerBuilder builder = new ContainerBuilder();
      Autofac.RegistrationExtensions.RegisterType<TaskEvaluator>(builder);
      Autofac.RegistrationExtensions.RegisterType<TaskTimer>(builder);
      DirectoryCatalog directoryCatalog = new DirectoryCatalog(Environment.CurrentDirectory);
      Autofac.Integration.Mef.RegistrationExtensions.RegisterComposablePartCatalog(builder, (ComposablePartCatalog) directoryCatalog, new Service[1]
      {
        (Service) new TypedService((Type) typeof (ITask))
      });
      Autofac.RegistrationExtensions.Register<IEnumerable<TaskInfo>>(builder, (Func<IComponentContext, IEnumerable<TaskInfo>>) (c => Enumerable.Select<Export, TaskInfo>(Autofac.Integration.Mef.RegistrationExtensions.ResolveExports<ITask>(ResolutionExtensions.Resolve<IComponentContext>(c)), (Func<Export, TaskInfo>) (e => new TaskInfo(TimeSpan.FromMilliseconds((double) (int) e.Metadata["MinInterval"]), (string) e.Metadata["Name"], (Func<ITask>) (() => (ITask) e.Value)))))).As<IEnumerable<TaskInfo>>();
      using (IContainer container = builder.Build(ContainerBuildOptions.None))
        ResolutionExtensions.Resolve<TaskTimer>((IComponentContext) container).Run();
    }
  }
}
