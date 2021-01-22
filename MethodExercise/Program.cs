using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
 Console.WriteLine("What is your favorite color?");
                var faveColor = Console.ReadLine();
 Console.WriteLine("What is your favorite drink?");
            var faveDrink = Console.ReadLine();
            Console.WriteLine("What is your favorite number?");
            var faveNumber = Console.ReadLine();

         
            Console.WriteLine($"One day, {name}'s internet went out and he was so angry. Because of this he ordered {faveNumber} {faveDrink}'s. " + $"After {faveNumber} drinks....he passed out on the floor.");





        }
    }
}
