using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI
{
  public static class ContainerConfig
  {
    public static IContainer Configure()
    {
      var builder = new ContainerBuilder();

      builder.RegisterType<PersonProcessor>().As<IPersonProcessor>();
      builder.RegisterType<TextDataAccess>().As<IDataAccess>();
      builder.RegisterType<FileService>().As<IFileService>();
      //builder.RegisterType<ColumnOrderProcessor>().As<IColumnOrderProcessor>(); 
      builder.RegisterType<PeopleDashboard>();

      return builder.Build();
    }
  }
}
