using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class BarmanDirector
    {
        private IBuilder _builder;
        public BarmanDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void PreparedPinaColada()
        {
            _builder.Reset();
            _builder.SetAlcohol(10);
            _builder.SetWater(25);
            _builder.SetMilk(5);
            _builder.AddIngredients("Tequila");
            _builder.AddIngredients("Jugo de piña");
            _builder.AddIngredients("Ron");
            _builder.Mix();
            _builder.Rest(1000);
        }

        public void PreparedMargarita()
        {
            _builder.Reset();
            _builder.SetAlcohol(15);
            _builder.SetWater(60);            
            _builder.AddIngredients("Mezcal");
            _builder.AddIngredients("Coñak");
            _builder.AddIngredients("Ciruela");
            _builder.Mix();
            _builder.Rest(2000);
        }
    }
}
