using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public static class StringExtensions
  {
    public static string FullFilePath(this string fileName)
    {
      return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
    }

    public static List<string> LoadFile(this string file)
    {
      if (File.Exists(file) == false)
      {
        return new List<string>();
      }

      return File.ReadAllLines(file).ToList();
    }
  }
}
