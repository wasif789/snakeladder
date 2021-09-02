using System;

namespace snakeladderprob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to snake ladder simulation");
            int rollDice;
            Random random = new Random();
            rollDice = random.Next(1, 7);
            Console.WriteLine("Rolled Dice number is:" + rollDice);
        }
    }
}
