using System;
using System.Threading;

namespace Facade
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Проверка истории кредитов банка пользователя " + c.Name);
            Thread.Sleep(1000);
            return true;
        }
    }
}
