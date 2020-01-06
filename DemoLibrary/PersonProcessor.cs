using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public class PersonProcessor : IPersonProcessor
  {
    public IEnumerable<PersonModel> LoadPeople(IDataAccess dataAccess)
    {
      throw new NotImplementedException();
    }
  }
}
