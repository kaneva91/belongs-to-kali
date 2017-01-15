using System.Collections.Generic;
using System.Linq;

namespace _03AnimalHierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {    // Trowing exeptions
             //Tomcat tomcat = new Tomcat("Tommy", 2.6, GenderType.Female);
             //Kitten kitty = new Kitten("Kitty", 2.6, GenderType.Male);

            IEnumerable<Animal> animals = new List<Animal>()
            {
                new Dog("Rex", 4.5, GenderType.Male),
                new Cat("Lilly", 1.2, GenderType.Female),
                new Frog("Bob", 0.4, GenderType.Female),
                new Kitten("Miss Kitty", 1.2, GenderType.Female),
                new Tomcat("Thomas", 4.6, GenderType.Male)
            };

            var agerageAge = animals.Average(x => x.Age);
        }
    }
}
