using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
  public partial class PeopleDashboard : Form
  {
    private IPersonProcessor _personProcessor;
    private BindingList<PersonModel> _people = new BindingList<PersonModel>();

    public PeopleDashboard(IPersonProcessor personProcessor)
    {
      InitializeComponent();
      _personProcessor = personProcessor;
      SetUpBinding();
      LoadPeople();
    }

    private void SetUpBinding()
    {
      peopleListBox.DataSource = _people;
      peopleListBox.DisplayMember = "FullName";
    }

    private void LoadPeople()
    {
      List<PersonModel> people = new List<PersonModel>();
      people = _personProcessor.LoadPeople().ToList();

      foreach (var person in people)
      {
        _people.Add(person);
      }

    }
  }
}
