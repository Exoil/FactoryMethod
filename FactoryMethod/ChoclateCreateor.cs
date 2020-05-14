using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class ChoclateCreateor
    {
        public abstract Chocolate FactoryChocolate();

    }

    public class MilkChocoalteCreator : ChoclateCreateor
    {
        public override Chocolate FactoryChocolate()
        {
            return new MilkChocolate();
        }
    }

    public class ChocoalteWithNutsCreator : ChoclateCreateor
    {
        public override Chocolate FactoryChocolate()
        {
            return new ChocolateWithNuts();
        }
    }

    public class DarkChocolateCreator : ChoclateCreateor
    {
        public override Chocolate FactoryChocolate()
        {
            return new DarkChocolate();
        }
    }

}
