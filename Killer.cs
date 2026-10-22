using System;

namespace project
{
    class Killer : Bot
    {
        public int Health {get; set;}= 100;

        public void Lazer()
        {
            Console.WriteLine(Name + " A activat atacul cu lazerul ");
        }
    }
}