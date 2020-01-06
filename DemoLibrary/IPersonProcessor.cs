using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public interface IPersonProcessor
  {
    IEnumerable<PersonModel> LoadPeople(IDataAccess dataAccess);
  }
}
