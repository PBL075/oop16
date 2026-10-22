using System;
using project;

class Program
{
    static void Main()
    {
        Bot robotSimplu = new Bot();
        robotSimplu.Name = "Bot_Vasile";
        robotSimplu.speed = 12.5f;
        robotSimplu.Weight = 500;
        robotSimplu.RobotRun();

        Killer robotUcigator = new Killer();
        robotUcigator.Name = "Killer_Georgel";
        robotUcigator.speed = 45.5f;
        robotUcigator.Weight = 800;
        robotUcigator.RobotRun();
    }
}