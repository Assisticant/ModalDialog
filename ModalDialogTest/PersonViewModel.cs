using Assisticant.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModalDialogTest
{
    public class PersonViewModel
    {
        private Observable<string> _first =
          new Observable<string>();
        private Observable<string> _last =
          new Observable<string>();

        public string First
        {
            get { return _first; }
            set { _first.Value = value; }
        }

        public string Last
        {
            get { return _last; }
            set { _last.Value = value; }
        }

        public string Full
        {
            get
            {
                return First + " " + Last;
            }
        }
    }
}
