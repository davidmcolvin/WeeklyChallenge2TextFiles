using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public class TextDataAccess : IDataAccess
  {

    public List<PersonModel> LoadPeople()
    {
      List<PersonModel> output = new List<PersonModel>();

      IEnumerable<string> lines = GlobalConfig.AppKeyLookup("fileName").FullFilePath().LoadFile();

      ConvertToPersonModel(output, lines);

      return output;
    }

    private void ConvertToPersonModel(List<PersonModel> people, IEnumerable<string> lines)
    {
      foreach (var line in lines)
      {
        string[] parts = line.Split(',');
        PersonModel p = new PersonModel();

        p.FirstName = parts[0];
        p.LastName = parts[1];
        p.Age = short.Parse(parts[2]);
        p.IsAlive = bool.Parse(parts[3]);

        people.Add(p);
      }
    }

    public void SavePeople(List<PersonModel> people)
    {
      throw new NotImplementedException();
    }

  }
}
