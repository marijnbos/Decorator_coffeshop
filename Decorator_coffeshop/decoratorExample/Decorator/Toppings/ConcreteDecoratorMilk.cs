namespace Decorator_coffeshop.decoratorExample.Decorator.Toppings
{
    public class ConcreteDecoratorMilk : DecoratorToppings
    {
        public ConcreteDecoratorMilk(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + Milk";
        }

        public override double GetCost()
        {
            return base.GetCost() + 1;
        }
    }
}