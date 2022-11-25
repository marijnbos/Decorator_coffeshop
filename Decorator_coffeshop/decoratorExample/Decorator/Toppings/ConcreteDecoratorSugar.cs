namespace Decorator_coffeshop.decoratorExample.Decorator.Toppings
{
    public class ConcreteDecoratorSugar : DecoratorToppings
    {
        public ConcreteDecoratorSugar(IBeverage beverage) : base(beverage)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " + sugar";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.25;
        }
    }
}