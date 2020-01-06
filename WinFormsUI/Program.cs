using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
  static class Program
  {
    private static IContainer container;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Bootstrap();
      using (var scope = container.BeginLifetimeScope())
      {
        Application.Run(scope.Resolve<PeopleDashboard>());
      }

    }

    private static void Bootstrap()
    {
      container = ContainerConfig.Configure();
    }
  }
}
