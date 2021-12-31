using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new SandwichAssembly(new CheeseBurger());
            sandwich.Assemble();

            Console.WriteLine("PATRONES - BUILDER" + '\n');
            Console.WriteLine("Encargado de construir objetos complejos y utiliza un mecanismo de separar la representacion del objeto con su creacion" + '\n');

            Console.WriteLine( $"{sandwich.GetSandwich.Bread} {sandwich.GetSandwich.Cheese} {sandwich.GetSandwich.Protein} {sandwich.GetSandwich.Veggies} {sandwich.GetSandwich.Condiments}");
            Console.ReadLine();
        }
    }
}
