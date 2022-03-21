using System;

namespace Decorator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Создаем нашу пиццу
            Pizza peperoni_pizza = new Peperoni();
            peperoni_pizza = new TomatoPizza(peperoni_pizza); // пицца пеперони с томатами
            Console.WriteLine("Название: {0}", peperoni_pizza.Name);
            Console.WriteLine("Цена: {0}", peperoni_pizza.GetCost());
            //Хочу еще с сыром вот добавляю 
            peperoni_pizza = new ChessePizza(peperoni_pizza);
            Console.WriteLine("Название: {0}", peperoni_pizza.Name);
            Console.WriteLine("Цена: {0}", peperoni_pizza.GetCost());

            Pizza neopoliatana_pizza = new Neopolitana();
            neopoliatana_pizza = new ChessePizza(neopoliatana_pizza);// неополитана с большим кол-вом сыра 
            Console.WriteLine("Название: {0}", neopoliatana_pizza.Name);
            Console.WriteLine("Цена: {0}", neopoliatana_pizza.GetCost());

        }
    }
}
