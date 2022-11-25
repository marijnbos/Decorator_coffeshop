namespace Decorator_coffeshop.decoratorExample.Decorator
{
    public abstract class DecoratorToppings : IBeverage
    {
        private IBeverage _beverage;

        public DecoratorToppings(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public virtual string GetDescription()
        {
            return this._beverage.GetDescription();
        }

        public virtual double GetCost()
        {
            return this._beverage.GetCost();
        }
    }
}