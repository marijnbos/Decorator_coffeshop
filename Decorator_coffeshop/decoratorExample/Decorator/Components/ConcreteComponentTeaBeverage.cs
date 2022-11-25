namespace Decorator_coffeshop.decoratorExample
{
    public class ConcreteComponentBeverage : IBeverage
    {
        public string GetDescription()
        {
            return "tea";
        }

        public double GetCost()
        {
            return 2.10;
        }
    }
}