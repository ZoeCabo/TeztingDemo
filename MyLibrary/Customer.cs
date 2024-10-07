using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Customer
    {
           public string FirstName { get; set; }
           public string LastName { get; set; }

        public String FullName =>  $"{FirstName} {LastName}";
        
    }
}
