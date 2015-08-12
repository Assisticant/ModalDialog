using Assisticant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModalDialogTest
{
    public class ViewModelLocator : ViewModelLocatorBase
    {
        private PersonViewModel _person;

        public ViewModelLocator()
        {
            _person = new PersonViewModel();
            if (DesignMode)
            {
                _person.First = "Charles";
                _person.Last = "Darwin";
            }
        }

        public object Person
        {
            get { return ViewModel(() => _person); }
        }
    }
}
