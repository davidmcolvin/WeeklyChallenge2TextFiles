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

    public void AddPerson(List<PersonModel> people, PersonModel person)
    {
      people.Add(person);
    }

    public List<PersonModel> LoadPeople()
    {
      return _dataAccess.LoadPeople();
    }

    public void SavePeople(List<PersonModel> people)
    {
      _dataAccess.SavePeople(people);
    }
  }
}
