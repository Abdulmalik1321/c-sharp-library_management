using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Base(DateTime? Date = null)
    {

        private Guid _id = Guid.NewGuid();

        private DateTime _date = Date is null ? DateTime.Now : (DateTime)Date;
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