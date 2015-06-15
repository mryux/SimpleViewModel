using SimpleViewModel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleViewModel.TestForm
{
    class PersonViewModel : BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Male { get; set; }
        public State State { get; set; }
    }

    class State
    {
        public string Name { get; set; }
        public int Code { get; set; }
    }
}
