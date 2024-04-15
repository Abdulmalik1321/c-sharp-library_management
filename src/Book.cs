using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book(string Title, DateTime? Date = null)
    {

        private Guid _id = Guid.NewGuid();
        // Date is null ? "dddd":"dddd"


        private DateTime _date = Date is null ? DateTime.Now : (DateTime)Date;
        private string _title = Title;
        public string GetTitle()
        {
            return _title;
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