using System.ComponentModel.Design;

namespace PetStore;

internal class Program {
    static void Main(string[] args) {

        Dog dog1 = new Dog { Breed = "German Shepherd", Age = 2, Weight = 30 };
        Dog dog2 = new Dog { Breed = "Collie", Age = 1, Weight = 20 };

        Cat cat1 = new Cat { Weight = 10, Age = 3, Color = "Grey" };
        Cat cat2 = new Cat { Weight = 7, Age = 2, Color = "Orange" };

        Bird bird1 = new Bird { Type = "Parrot", Color = "Rainbow", CanFly = false };
        Bird bird2 = new Bird { Type = "Eagle", Color = "Brown", CanFly = true };

        List<IPet> pets = new List<IPet>();
        pets.AddRange(new IPet[] { dog1, dog2, cat1, cat2, bird1, bird2 });

        foreach (var pet in pets) {
            var aDog = pet as Dog;
            var aCat = pet as Cat;
            var aBird = pet as Bird;
            if (aDog is not null) {
                Console.WriteLine($"Breed is {aDog.Breed}, Age is {aDog.Age}, Weight is {aDog.Weight}");
            } 
            if (aCat is not null) {
                Console.WriteLine($"Weight is {aCat.Weight}, Age is {aCat.Age}, Color is {aCat.Color}");
            } else if (aBird is not null) {
                Console.WriteLine($"Color is {aBird.Color}, Type is {aBird.Type}, Can Fly {aBird.CanFly}");
            }
            
        }
    }
}
