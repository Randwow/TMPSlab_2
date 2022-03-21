using System;
namespace Decorator
{
    class Neopolitana: Pizza
    {
        public Neopolitana() : base("Неополитанская пицца") { }

        public override int GetCost()
        {
            return 12;
        }
    }
}
