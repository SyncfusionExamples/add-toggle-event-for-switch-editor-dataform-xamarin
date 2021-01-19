using System;
using System.Collections.Generic;
using System.Text;

namespace DataFormXamarin
{
    public class DataFormViewModel
    {
        private DataFormModel contactsInfo;
        public DataFormModel ContactsInfo
        {
            get { return this.contactsInfo; }
            set { this.contactsInfo = value; }
        }
        public DataFormViewModel()
        {
            this.contactsInfo = new DataFormModel();
        }
    }
}
