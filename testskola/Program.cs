using System;

namespace testskola
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipment vec = new Equipment { Name = "židle"};
            Equipment vec2 = new Equipment { Name = "stůl" };
            Equipment vec3 = new Equipment { Name = "kružítko" };
            vec.Borrow(new User { FirstName = "Filip", LastName = "Tomín", Days = 10, });
            vec.Borrow(new User { FirstName = "Filip", LastName = "Tomín", Days = 15 });
            vec2.Borrow(new User { FirstName = "Adam", LastName = "Plašil", Days = 15, });
            vec3.Borrow(new User { FirstName = "Filip", LastName = "Tomín", Days = 5 });
            Console.WriteLine(vec);
            Console.WriteLine(vec2);
            Console.WriteLine(vec3);
            Console.ReadKey();

            

        }
    }
}
