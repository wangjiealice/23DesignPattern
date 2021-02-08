using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern2
{
    class NoQuarterState : IState
    {
        CandyMachine candyMachine;
        public NoQuarterState(CandyMachine machine)
        {
            candyMachine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Insert a quarter.");
            candyMachine.SetState(candyMachine.GetHasQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You has not inserted a quarter.");
        }

        public void TurnQuarter(bool isWin)
        {
            Console.WriteLine("You turned,but have not inserted a quarter.");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to insert a quarter first.");
        }
    }
}
