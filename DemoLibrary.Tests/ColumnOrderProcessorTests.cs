using Autofac.Extras.Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
  public class ColumnOrderProcessorTests
  {
    [Fact]
    public void LoadColumnOrder_ValidCall()
    {

      using (var mock = AutoMock.GetLoose())
      {
        mock.Mock<IFileService>()
        .Setup(x => x.LoadFile(null))
        .Returns(GetSampleFile());

        var cls = mock.Create<TextDataAccess>();
        var expected = new ColumnOrderModel
        {
          FirstColumn = Enums.ColumnNames.FirstName,
          SecondColumn = Enums.ColumnNames.LastName,
          ThirdColumn = Enums.ColumnNames.Age,
          FourthColumn = Enums.ColumnNames.IsAlive
        };

        var actual = cls.LoadColumnOrderText();

        Assert.True(actual != null);
        Assert.Equal(expected.FirstColumn, actual.FirstColumn);
        Assert.Equal(expected.SecondColumn, actual.SecondColumn);
        Assert.Equal(expected.ThirdColumn, actual.ThirdColumn);
        Assert.Equal(expected.FourthColumn, actual.FourthColumn);

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
  }
}
