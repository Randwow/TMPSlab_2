using System;
using System.Threading;

namespace Facade
{
    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Проверка целесообразности выдачи кредита " + c.Name);
            Thread.Sleep(1000);
            return true;
        }
    }
}
