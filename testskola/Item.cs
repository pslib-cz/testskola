using System;
using System.Collections.Generic;
using System.Text;

namespace testskola
{
    abstract class Item
    {
        static int pocitadlo = 0;
        
        public int id { get; set; }

        public void ID()
        {
            id = pocitadlo;
            pocitadlo ++;
        }
        public Item()
        {
            ID();
        }
    }
}
