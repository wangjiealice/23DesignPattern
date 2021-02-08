using System;

namespace StatePattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            CandyMachine candyMachine = new CandyMachine(10);
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("This is {0} times.", i + 1);
                candyMachine.InsertQuarter();
                candyMachine.TurnQuarter();
                Console.WriteLine();
            }
        }
    }
}
