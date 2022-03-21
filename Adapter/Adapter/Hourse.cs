using System;
namespace Adapter
{
    //Наш адаптируемый класс который надо использовать в качетсве обьекта ITransport
    public class Hourse: IAnimal
    {
        public void Move() {
            Console.WriteLine(" Теперь путешественник передвигается на лошади \n");
        }
    }
}
