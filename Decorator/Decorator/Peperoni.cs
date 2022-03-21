using System;
namespace Decorator
{
    class Peperoni : Pizza
    {
        public Peperoni() : base("Пицца Пеперони")
        { }
        public override int GetCost()
        {
            return 10;
        }
    }
}
