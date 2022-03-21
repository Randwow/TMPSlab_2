using System;
namespace Decorator
{
    class ChessePizza : PizzaDecorator
    {
        public ChessePizza(Pizza p)
            : base(p.Name + ", с сыром", p)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 5;
        }
    }
}
