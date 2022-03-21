using System;
using System.Threading;

namespace Facade
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Проверка если банк может выдать займ для " + c.Name);
            Thread.Sleep(1000);
            return true;
        }
    }
}
