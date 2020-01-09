using Autofac.Extras.Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
  public class TextDataAccessTests
  {
    [Fact]
    public void LoadPeople_ValidCall()
    {

      using (var mock = AutoMock.GetLoose())
      {
        mock.Mock<IFileService>()
        .Setup(x => x.LoadFile(null))
        .Returns(GetSampleFile());

        mock.Mock<IColumnOrderProcessor>()
        .Setup(x => x.LoadColumnOrder())
        .Returns(GetSampleFileFirstLineAsColumnOrderModel());


        var cls = mock.Create<TextDataAccess>();
        var expected = GetSamplePeople();

        var actual = cls.LoadPeople();

        Assert.True(actual != null);
        Assert.Equal(expected.Count, actual.Count);

        for (int i = 0; i < expected.Count(); i++)
        {
          Assert.Equal(expected[i].FirstName, actual[i].FirstName);
          Assert.Equal(expected[i].LastName, actual[i].LastName);
        }

      }
    }

    private IEnumerable<string> GetSampleFile()
    {
      List<string> output = new List<string>();
      output.Add("FirstName,LastName,Age,IsAlive");
      output.Add("Test1,TestLast1,11,True");
      output.Add("Test2,TestLast2,22,False");
      output.Add("Test3,TestLast3,33,True");

      return output;
    }

    private ColumnOrderModel GetSampleFileFirstLineAsColumnOrderModel()
    {
      ColumnOrderModel output = new ColumnOrderModel();

      output.FirstColumn = Enums.ColumnNames.FirstName;
      output.SecondColumn = Enums.ColumnNames.LastName;
      output.ThirdColumn = Enums.ColumnNames.Age;
      output.FourthColumn = Enums.ColumnNames.IsAlive;

      return output;
      

    }

    private List<PersonModel> GetSamplePeople()
    {
      List<PersonModel> output = new List<PersonModel>();
      output.Add(new PersonModel
      {
        FirstName = "Test1",
        LastName = "TestLast1",
        Age = 11,
        IsAlive = true
      });
      output.Add(new PersonModel
      {
        FirstName = "Test2",
        LastName = "TestLast2",
        Age = 22,
        IsAlive = false
      });
      output.Add(new PersonModel
      {
        FirstName = "Test3",
        LastName = "TestLast3",
        Age = 33,
        IsAlive = true
      });

      return output;
    }
  }
}
