using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book(string Title, DateTime? Date = null) : Base(Date)
    {

        private string _title = Title;
        public string GetTitle()
        {
            return _title;
        }
    }
}