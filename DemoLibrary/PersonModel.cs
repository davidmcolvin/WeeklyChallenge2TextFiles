using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
  public class PersonModel
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public short Age { get; set; }
    public bool IsAlive { get; set; }

    public string DisplayText
    {
      get
      {
        string isAliveText = "dead";
        if (IsAlive)
        {
          isAliveText = "alive";
        }
        return $"{FirstName} {LastName} is {Age} and is {isAliveText}. ";

      }
    }

  }
}
