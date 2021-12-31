using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new SandwichBuilder()
                .WithMeat()
                .WithCheeseCheddar()
                .WithCondimentsMayoMustard();

            Console.WriteLine("PATRONES - FLUENT BUILDER" + '\n');
            Console.WriteLine("Tiene una implementación más fluida que la forma tradicional. Solamente necesitamos un Builder." + '\n');

            Console.WriteLine( $"{sandwich.sandwich.Protein} , {sandwich.sandwich.Cheese} , {sandwich.sandwich.Condiments}");
            Console.ReadLine();
        }
    }
}
