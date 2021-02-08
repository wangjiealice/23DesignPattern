using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern2
{
    class HasQuarterState : IState
    {
        CandyMachine candyMachine;
        public HasQuarterState(CandyMachine machine)
        {
            candyMachine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You have already insert a quarter.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Eject a quarter.");
            candyMachine.SetState(candyMachine.GetNoQuarterState());
        }

        public void TurnQuarter(bool isWin)
        {
            Console.WriteLine("You turned.");
            
            if(isWin)
            {
                candyMachine.SetState(candyMachine.GetWinnerState());
            }
            else
            {
                candyMachine.SetState(candyMachine.GetSoldState());
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No candy can distribute.");
        }
    }
}
