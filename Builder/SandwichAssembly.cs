using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SandwichAssembly
    {
        private SandwichBuilder _sandwichBuilder;

        public SandwichAssembly(SandwichBuilder sandwichBuilder)
        {
            _sandwichBuilder = sandwichBuilder;
        }

        public void Assemble()
        {
            _sandwichBuilder.AddBread();
            _sandwichBuilder.AddCheese();
            _sandwichBuilder.AddVeggies();
            _sandwichBuilder.AddCondiments();
        }

        public Sandwich GetSandwich
        {
            get { return _sandwichBuilder.sandwich; }
        }
    }
}
