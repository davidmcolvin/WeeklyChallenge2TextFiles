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

        var actual = cls.LoadPeople(); ;

        Assert.True(actual != null);
        Assert.Equal(expected.Count, actual.Count);

        for (int i = 0; i < expected.Count(); i++)
        {
          Assert.Equal(expected[i].FirstName, actual[i].FirstName);
          Assert.Equal(expected[i].LastName, actual[i].LastName);
          Assert.Equal(expected[i].Age, actual[i].Age);
          Assert.Equal(expected[i].IsAlive, actual[i].IsAlive);
        }

      }
    }

    [Fact]
    public void AddPerson_ValidCall()
    {
      ColumnOrderModel columnOrder = new ColumnOrderModel();

      PersonModel person = new PersonModel();
      person.FirstName = "Test";
      person.LastName = "Testerson";
      person.Age = 10;
      person.IsAlive = true;

      using (var mock = AutoMock.GetLoose())
      {
        var cls = mock.Create<PersonProcessor>();
        var original = GetSamplePeople();
        var expected = original.ToList();
        expected.Add(person);

        cls.AddPerson(original, person);

        Assert.True(original != null);
        Assert.Equal(original.Count, expected.Count);

        for (int i = 0; i < expected.Count(); i++)
        {
          Assert.Equal(expected[i].FirstName, original[i].FirstName);
          Assert.Equal(expected[i].LastName, original[i].LastName);
          Assert.Equal(expected[i].Age, original[i].Age);
          Assert.Equal(expected[i].IsAlive, original[i].IsAlive);
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

