

namespace Builder
{
    public class SandwichBuilder
    {
        protected Sandwich _sandwich;

        public Sandwich sandwich
        {
            get { return _sandwich; }
        }

        public SandwichBuilder()
        {
            _sandwich = new Sandwich();
        }

        public SandwichBuilder WithMeat()
        {
            _sandwich.Protein = "Carne";
            return this;
        }

        public SandwichBuilder WithCheeseCheddar()
        {
            _sandwich.Cheese = "Queso cheddar";
            return this;
        }

        public SandwichBuilder WithCondimentsMayoMustard()
        {
            _sandwich.Condiments = "Mayonesa y Mostaza";
            return this;
        }

     
    }
}
