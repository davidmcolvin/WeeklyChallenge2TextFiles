using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public interface IPersonProcessor
  {
    List<PersonModel> LoadPeople();
    void AddPerson(List<PersonModel> people, PersonModel person);
  }
}
