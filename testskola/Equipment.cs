using System;
using System.Collections.Generic;
using System.Text;

namespace testskola
{
    class Equipment : Item, Borrowable
    {
        public string Name { get; set; }
     

        public void Borrow(User a)
        {
            history.Add(a);
            

        }
        public Equipment()
        {
            history = new List<Item>();
        }
        public List<Item> history { get; set; }
        
        public int kolikdni { get; set; }
        public string vystup { get; set; }
        public override string ToString()
        {
            
            foreach (User user in history)
            {
                kolikdni += user.Days;
             
                vystup +=  "Předmět: " + Name + " " + user.FirstName + " " + user.LastName + " " + user.Days + " " + " id:" + user.id  + "\n";
                
            }
            return vystup + "Celkově: " + kolikdni;
            
        }
    }
}
