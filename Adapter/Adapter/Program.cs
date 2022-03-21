using System;

namespace Adapter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Создаем нашего путешественника
            Driver driver = new Driver();
            //Создаем нашу машину путешественника 
            Auto auto = new Auto();
            //Ппутешественник начинает свой путь 
            driver.Travel(auto);
            Console.WriteLine("Появилось бездорожье дальше можно продлжить путь только на лошади \n");
            //Создаем лошдь
            Hourse hourse = new Hourse();
            //Используем адаптер 
            HourseToTransportAdapter hourse_transport = new HourseToTransportAdapter(hourse);
            //Продолжаем путь
            driver.Travel(hourse_transport);
        }
    }
}
