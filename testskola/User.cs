using System;
using System.Collections.Generic;
using System.Text;

namespace testskola
{
    class User : Item
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Days { get; set; }
        
        public override string ToString()
        {
            return FirstName + LastName + Days;
        }

    }
}
