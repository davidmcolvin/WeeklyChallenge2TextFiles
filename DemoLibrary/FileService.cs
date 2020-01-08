using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public class FileService : IFileService
  {

    private string FullFilePath(string fileName)
    {
      return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
    }

    public IEnumerable<string> LoadFile(string fileName)
    {
      if (File.Exists(FullFilePath(fileName)) == false)
      {
        return new List<string>();
      }

      return File.ReadAllLines(FullFilePath(fileName));
    }
  }
}
