using System;
namespace Adapter
{
    public class Driver
    {
        //Наш клиент который может путешествовать и использует обьект Itransport 
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
