using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class User(string Name, DateTime? Date = null)
    {
        private Guid _id = Guid.NewGuid();
        // Date is null ? "dddd":"dddd"


        private DateTime _date = Date is null ? DateTime.Now : (DateTime)Date;
        private string _name = Name;
        public string GetName()
        {
            return _name;
        }
        public DateTime GetDate()
        {
            return _date;
        }
        public Guid GetId()
        {
            return _id;
        }
    }
}