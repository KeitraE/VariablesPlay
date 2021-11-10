using System;

namespace PlayingWithVariablesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declared and initialized a variable
            //camelCase for the variable name
            //explicit typing
            string babyName = "Kyson";
            int babyAge = 1;
            char nickName = 'K';
            bool lovesSleeping = true;
            double nightLights = 3;
            decimal weight = 19.2m;

            Console.WriteLine($"My baby's name is {babyName}. He is a {babyAge} year old and he has {nightLights} night lights. It is {lovesSleeping} that he loves to sleep, which is why he is {weight} pounds now.");




        }
    }
}
