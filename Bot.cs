using System;

namespace project
{
    class Bot : IRun
    {
        public string Name{get; set;} 
        public float speed{get; set;} 
        public int Weight{get; set;} 
        public void RobotRun()
        {
            Console.WriteLine("Ruleaza cu viteza de "+ speed);
        }
    }
}