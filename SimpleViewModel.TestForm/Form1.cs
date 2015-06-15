using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleViewModel.Core;

namespace SimpleViewModel.TestForm
{
    public partial class Form1 : Form
    {
        private PersonViewModel ViewModel;

        public Form1()
        {
            InitializeComponent();

            ViewModel = new PersonViewModel() { FirstName = "firstName", LastName = "lastName", Male = true };

            ViewModel.BindTo(vm => vm.FirstName, _textBoxFirstName, c => c.Text, null);
            ViewModel.BindTo(vm => vm.LastName, _textBoxLastName, c => c.Text, null);
            ViewModel.BindTo(vm => vm.Male, _checkBoxMale, c => c.Checked, null);

            ViewModel.BindTo(vm => vm.State, _comboBoxState, c => c.SelectedItem, comboBox =>
            {
                BindingList<State> lStates = new BindingList<State>();

                lStates.Add(new State() { Name = "NSW", Code = 2 });
                lStates.Add(new State() { Name = "VIC", Code = 3 });

                comboBox.DataSource = lStates;
                comboBox.DisplayMember = "Name";
            });
        }
    }
}
