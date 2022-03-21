using System;
namespace Flyweight
{
    abstract class House
    {
        //интерфейс через которое приспособленцы получат состояние 
        protected int stages; // количество этажей

        public abstract void Build(double longitude, double latitude);
    }
}
