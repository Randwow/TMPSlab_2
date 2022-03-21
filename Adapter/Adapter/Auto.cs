using System;
namespace Adapter
{
    public class Auto: ITransport
    {
        public void Drive() {
            Console.WriteLine("Путешественник передвигается на машине \n");
        }
    }
}
