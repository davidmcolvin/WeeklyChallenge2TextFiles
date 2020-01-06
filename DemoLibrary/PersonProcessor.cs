using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public class PersonProcessor : IPersonProcessor
  {
    private IDataAccess _dataAccess;
    public PersonProcessor(IDataAccess dataAccess)
    {
      _dataAccess = dataAccess;
    }

    public IEnumerable<PersonModel> LoadPeople()
    {
      return _dataAccess.LoadPeople();
    }
  }
}
