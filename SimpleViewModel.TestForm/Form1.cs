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

            //BankModel.BindList("AccountName", _listBoxAccounts);
            //BankModel.BindList("AccountNameIndex", _comboBoxAccounts, "SelectedIndex");
        }

        //public void BindList(string pPropertyName, ListBox pListBox, string pControlPropertyName = "SelectedItem")
        //{
        //    BindingList<ListBoxItem> nl = new BindingList<ListBoxItem>();

        //    nl.Add(new ListBoxItem() { Id = 1, FirstName = "Jane", LastName = "Doe" });
        //    nl.Add(new ListBoxItem() { Id = 2, FirstName = "Mary", LastName = "Smith" });

        //    pListBox.DataSource = nl;
        //    pListBox.DisplayMember = "DisplayName";

        //    pListBox.DataBindings.Add(pControlPropertyName, _BindingSource, pPropertyName);
        //}

        //public void BindList(string pPropertyName, ComboBox pCombo, string pControlPropertyName = "SelectedItem")
        //{
        //    BindingList<ListBoxItem> nl = new BindingList<ListBoxItem>();

        //    nl.Add(new ListBoxItem() { Id = 1, FirstName = "Jane", LastName = "Doe" });
        //    nl.Add(new ListBoxItem() { Id = 2, FirstName = "Mary", LastName = "Smith" });
        //    nl.Add(new ListBoxItem() { Id = 3, FirstName = "dick", LastName = "Smith" });

        //    pCombo.DataSource = nl;
        //    pCombo.DisplayMember = "DisplayName";

        //    pCombo.DataBindings.Add(pControlPropertyName, _BindingSource, pPropertyName);
        //}

    }
}
