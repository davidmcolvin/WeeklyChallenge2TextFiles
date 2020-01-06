using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public static class GlobalConfig
  {
    public static string AppKeyLookup(string name)
    {
      return ConfigurationManager.AppSettings[name];
    }

  }
}
