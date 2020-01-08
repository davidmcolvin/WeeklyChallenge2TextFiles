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
    private List<PersonModel> _people = new List<PersonModel>();

    public PeopleDashboard(IPersonProcessor personProcessor)
    {
      InitializeComponent();
      _personProcessor = personProcessor;
      LoadPeople();
      RefreshBinding();
    }

    private void RefreshBinding()
    {
      peopleListBox.DataSource = null;
      peopleListBox.DataSource = _people;
      peopleListBox.DisplayMember = "FullName";
    }

    private void LoadPeople()
    {
      List<PersonModel> people = new List<PersonModel>();
      people = _personProcessor.LoadPeople();

      foreach (var person in people)
      {
        _people.Add(person);
      }

    }

    private void addUserButton_Click(object sender, EventArgs e)
    {
      PersonModel p = new PersonModel();
      p.FirstName = firstNameTextBox.Text;
      p.LastName = lastNameTextBox.Text;
      p.Age = Convert.ToInt16(ageNumericUpDown.Value);

      _personProcessor.AddPerson(_people, p);

      RefreshBinding();
    }
  }
}
