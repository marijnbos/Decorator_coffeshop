using System;
using Decorator_coffeshop.decoratorExample;
using Decorator_coffeshop.decoratorExample.Decorator;
using Decorator_coffeshop.decoratorExample.Decorator.Toppings;

namespace Decorator_coffeshop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Create EcomomyCar instance.   
            IBeverage coffe = new ConcreteComponentCoffeeBeverage();   
    
            //Wrp EconomyCar instancw with BasicAccessories.   
            DecoratorToppings objAccessoriesDecorator = new ConcreteDecoratorSugar(coffe);   
  
            //Wrap EconomyCar instance with AdvancedAccessories instance.   
            objAccessoriesDecorator = new ConcreteDecoratorMilk(objAccessoriesDecorator);   
  
            Console.Write("Beverage Detials: " + objAccessoriesDecorator.GetDescription());   
            Console.WriteLine("\n\n");   
            Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());   
  
            Console.Read();   
        }
    }
}