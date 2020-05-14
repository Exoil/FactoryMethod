using System;

namespace FactoryMethod
{
    public enum ChocolateType
    {
        MILK = 1000,
        DARK = 2000,
        NUTS = 3000,

    }


    class Program
    {
        static int ChoseOption()
        {
            Char input = (Char)Console.Read();
            int result = 0;

            if (Int32.TryParse(input.ToString(), out result))
            {
                return result;
            }
           
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method");
            Chocolate chocolate;
            ChoclateCreateor factory;

            Console.WriteLine($"1. {ChocolateType.MILK}{Environment.NewLine}2. {ChocolateType.DARK}{Environment.NewLine}3. With {ChocolateType.NUTS}{Environment.NewLine}4. Exit");
            int choice = 1;
            while(choice > 0 )
            {
                choice = ChoseOption();
                switch(choice)
                {
                    case 1:
                        factory = new MilkChocoalteCreator();
                        chocolate = factory.FactoryChocolate();
                        Console.WriteLine(chocolate);
                        break;

                    case 2:
                        factory = new DarkChocolateCreator();
                        chocolate = factory.FactoryChocolate();
                        Console.WriteLine(chocolate);
                        break;

                    case 3:
                        factory = new ChocoalteWithNutsCreator();
                        chocolate = factory.FactoryChocolate();
                        Console.WriteLine(chocolate);
                        break;

                    case 4:
                        choice = -1;
                        break;

                }
            }

            Console.WriteLine("End");
        }
    }
}
