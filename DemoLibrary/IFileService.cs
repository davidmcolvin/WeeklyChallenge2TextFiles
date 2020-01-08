using System.Collections.Generic;

namespace DemoLibrary
{
  public interface IFileService
  {
    IEnumerable<string> LoadFile(string fileName);
  }
}