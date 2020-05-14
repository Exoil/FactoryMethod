using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Chocolate
    {
        public string name { get; set; }

        public Chocolate()
        {
            name = "Nomal Chocolate";
        }

        public override string ToString()
        {
            return name;
        }
    }

    public class MilkChocolate : Chocolate
    {
        public string AddMilk()
        {
            return "Milk";
        }

        public MilkChocolate():base()
        {
            name += $" {AddMilk()}";
        }

    }

    public class ChocolateWithNuts : Chocolate
    {
        public string AddNuts()
        {
            return "Nuts";
        }

        public ChocolateWithNuts() : base()
        {
            name += $" {AddNuts()}";
        }
    }

    public class DarkChocolate : Chocolate
    {
        public string AddCocoa()
        {
            return "Cocoa";
        }

        public DarkChocolate() : base()
        {
            name += $" {AddCocoa()}";
        }
    }

}
