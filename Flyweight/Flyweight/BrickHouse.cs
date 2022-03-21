﻿using System;
namespace Flyweight
{
    class BrickHouse:House
    {
        public BrickHouse()
        {
            stages = 5;
        }

        public override void Build(double longitude, double latitude)
        {
            Console.WriteLine("Построен кирпичный дом из 5 этажей; координаты: {0} широты и {1} долготы",
                latitude, longitude);
        }
    }
}
