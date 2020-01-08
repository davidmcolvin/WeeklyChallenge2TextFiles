using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public interface IDataAccess
  {
    List<PersonModel> LoadPeople();
    void SavePeople(List<PersonModel> people);
  }
}
