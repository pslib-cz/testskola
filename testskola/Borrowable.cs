using System;
using System.Collections.Generic;
using System.Text;

namespace testskola
{
    interface Borrowable
    {
        List<Item> history { get; set; }
        void Borrow(User a);
    }
}
