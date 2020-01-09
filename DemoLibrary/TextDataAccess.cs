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
    private IFileService _fileService;
    //private IColumnOrderProcessor _columnOrderProcessor;

    public TextDataAccess(IFileService fileService)
    {
      _fileService = fileService;
      //_columnOrderProcessor = columnOrderProcessor;
    }

    public List<PersonModel> LoadPeople()
    {
      List<PersonModel> output = new List<PersonModel>();

      string fileName = GlobalConfig.AppKeyLookup("fileName");

      IEnumerable<string> lines = _fileService.LoadFile(fileName);

      ConvertToPersonModel(output, lines);

      return output;
    }

    public ColumnOrderModel LoadColumnOrderText(IEnumerable<string> lines = null)
    {
      ColumnOrderModel output = new ColumnOrderModel();

      string fileName = GlobalConfig.AppKeyLookup("fileName");

      if (lines == null)
      {
        lines = _fileService.LoadFile(fileName);
      }

      foreach (var line in lines)
      {
        string[] parts = line.Split(',');
        for (int i = 0; i < parts.Length; i++)
        {
          FigureOutColumnOrder(output, i, parts[i]);
        }
        break;
      }

      return output;
    }

    private void FigureOutColumnOrder(ColumnOrderModel output, int i, string columnName)
    {
      switch (i)
      {
        case 0:
          output.FirstColumn = FigureOutColumnName(columnName);
          break;
        case 1:
          output.SecondColumn = FigureOutColumnName(columnName);
          break;
        case 2:
          output.ThirdColumn = FigureOutColumnName(columnName);
          break;
        case 3:
          output.FourthColumn = FigureOutColumnName(columnName);
          break;
        default:
          throw new NotImplementedException();
      }
    }

    private Enums.ColumnNames FigureOutColumnName(string columnName)
    {
      switch (columnName)
      {
        case "FirstName":
          return Enums.ColumnNames.FirstName;
        case "LastName":
          return Enums.ColumnNames.LastName;
        case "Age":
          return Enums.ColumnNames.Age;
        case "IsAlive":
          return Enums.ColumnNames.IsAlive;
        default:
          throw new InvalidDataException();
      }
    }

    private void ConvertToPersonModel(List<PersonModel> people, IEnumerable<string> lines)
    {
      ColumnOrderModel columnOrder = LoadColumnOrderText();

      bool isSkipFirstLineDone = false;
      foreach (var line in lines)
      {
        if (isSkipFirstLineDone == true)
        {
          PersonModel p = LoadPerson(line, columnOrder);

          people.Add(p);
        }
        isSkipFirstLineDone = true;
      }
    }

    private PersonModel LoadPerson(string line, ColumnOrderModel columnOrder)
    {
      PersonModel p = new PersonModel();

      string[] parts = line.Split(',');

      for (int i = 1; i < 5; i++)
      {
        LoadColumnOrder(p, columnOrder, parts, i);
      }

      return p;
    }

    private void LoadColumnOrder(PersonModel p, ColumnOrderModel columnOrder, string[] parts, int columnNumber)
    {
      switch (columnNumber)
      {
        case 1:
          LoadColumnName(p, columnOrder.FirstColumn, parts[0]);
          break;
        case 2:
          LoadColumnName(p, columnOrder.SecondColumn, parts[1]);
          break;
        case 3:
          LoadColumnName(p, columnOrder.ThirdColumn, parts[2]);
          break;
        case 4:
          LoadColumnName(p, columnOrder.FourthColumn, parts[3]);
          break;
        default:
          throw new InvalidDataException();
      }
    }

    private void LoadColumnName(PersonModel p, Enums.ColumnNames columnName, string myValue)
    {
      switch (columnName)
      {
        case Enums.ColumnNames.FirstName:
          p.FirstName = myValue;
          break;
        case Enums.ColumnNames.LastName:
          p.LastName = myValue;
          break;
        case Enums.ColumnNames.Age:
          p.Age = short.Parse(myValue);
          break;
        case Enums.ColumnNames.IsAlive:
          p.IsAlive = bool.Parse(myValue);
          break;
        default:
          throw new InvalidDataException();
      }
    }

    public void SavePeople(List<PersonModel> people)
    {
      string filePathAndfileName = 
        $@"{GlobalConfig.AppKeyLookup("filePath")}\{GlobalConfig.AppKeyLookup("fileName")}";
      List<string> output = new List<string>();


      IEnumerable<string> origFile = File.ReadAllLines(filePathAndfileName);

      ColumnOrderModel columnOrder = LoadColumnOrderText(origFile);

      output.Add(FigureOutTextOutput(null,columnOrder));

      foreach (var person in people)
      {
        output.Add(FigureOutTextOutput(person, columnOrder));
      }

      File.WriteAllLines(filePathAndfileName, output);
      
    }

    private static string FigureOutTextOutput(PersonModel person, ColumnOrderModel columnOrder)
    {
      StringBuilder sb = new StringBuilder();

      for (int i = 1; i < 5; i++)
      {
        switch (i)
        {
          case 1:
            LoadColumnOutputText(person, columnOrder.FirstColumn, sb);
            break;
          case 2:
            LoadColumnOutputText(person, columnOrder.SecondColumn, sb);
            break;
          case 3:
            LoadColumnOutputText(person, columnOrder.ThirdColumn, sb);
            break;
          case 4:
            LoadColumnOutputText(person, columnOrder.FourthColumn, sb);
            break;
          default:
            throw new InvalidDataException();
        }

      }

      return sb.ToString().TrimEnd(',');
    }

    private static void LoadColumnOutputText(PersonModel person, Enums.ColumnNames columnName, StringBuilder sb)
    {

      switch (columnName)
      {
        case Enums.ColumnNames.FirstName:
          if (person != null)
          {
            sb.Append($"{person.FirstName},");
          }
          else
          {
            sb.Append("FirstName,");
          }
          break;
        case Enums.ColumnNames.LastName:
          if (person != null)
          {
            sb.Append($"{person.LastName},");
          }
          else
          {
            sb.Append("LastName,");
          }
          break;
        case Enums.ColumnNames.Age:
          if (person != null)
          {
            sb.Append($"{person.Age},");
          }
          else
          {
            sb.Append("Age,");
          }
          break;
        case Enums.ColumnNames.IsAlive:
          if (person != null)
          {
            sb.Append($"{person.IsAlive},");
          }
          else
          {
            sb.Append("IsAlive,");
          }
          break;
        default:
          break;
      }
    }

    private void ConvertToIEnumerableString(List<PersonModel> people, IEnumerable<string> lines)
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

  }
}
