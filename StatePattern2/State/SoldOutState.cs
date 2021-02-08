using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern2
{
    class SoldOutState : IState
    {
        CandyMachine candyMachine;
        public SoldOutState(CandyMachine machine)
        {
            candyMachine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Already sold out.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You has not inserted a quarter.");
        }

        public void TurnQuarter(bool isWin)
        {
            Console.WriteLine("Already sold out.");
        }

        public void Dispense()
        {
            Console.WriteLine("Already sold out.");
        }
    }
}
