using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement;
public class User(string Name, DateTime? Date = null) : Base(Date)
{
    private string _name = Name;
    public string GetName()
    {
        return _name;
    }

}