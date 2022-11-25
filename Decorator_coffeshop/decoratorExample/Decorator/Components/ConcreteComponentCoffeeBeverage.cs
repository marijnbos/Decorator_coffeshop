namespace Decorator_coffeshop.decoratorExample
{
    public class ConcreteComponentCoffeeBeverage : IBeverage
    {
        public string GetDescription()
        {
            return "coffe";
        }

        public double GetCost()
        {
            return 2.50;
        }
    }
}