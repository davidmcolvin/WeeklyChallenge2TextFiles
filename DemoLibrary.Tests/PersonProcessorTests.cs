using Autofac.Extras.Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
  public class PersonProcessorTests
  {
    [Fact]
    public void LoadPeople_ValidCall()
    {

      using (var mock = AutoMock.GetLoose())
      {
        mock.Mock<IDataAccess>()
          .Setup(x => x.LoadPeople())
          .Returns(GetSamplePeople());

        var cls = mock.Create<PersonProcessor>();
        var expected = GetSamplePeople();

        var actual = cls.LoadPeople().ToList(); ;

        Assert.True(actual != null);
        Assert.Equal(expected.Count, actual.Count);

        for (int i = 0; i < expected.Count(); i++)
        {
          Assert.Equal(expected[i].FirstName, actual[i].FirstName);
          Assert.Equal(expected[i].LastName, actual[i].LastName);
        }

      }
    }

    private List<PersonModel> GetSamplePeople()
    {
      List<PersonModel> output = new List<PersonModel>
      {
        new PersonModel
        {
          FirstName = "Jim",
          LastName = "Smith",
          Age = 45,
          IsAlive = false
        },
        new PersonModel
        {
          FirstName = "Felix",
          LastName = "Nobel",
          Age = 30,
          IsAlive = false
        },
        new PersonModel
        {
          FirstName = "Jack",
          LastName = "Ryan",
          Age = 43,
          IsAlive = true
        },
        new PersonModel
        {
          FirstName = "John",
          LastName = "Doe",
          Age = 62,
          IsAlive = true
        }
      };

      return output;
    }

  }
}

