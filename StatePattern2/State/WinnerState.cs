using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern2
{
    class WinnerState : IState
    {
        CandyMachine candyMachine;
        public WinnerState(CandyMachine machine)
        {
            candyMachine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, you will get a candy.");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can not eject, you have turned.");
        }

        public void TurnQuarter(bool isWin)
        {
            Console.WriteLine("You have turned.");
        }

        public void Dispense()
        {
            ++candyMachine.CurrentTurnTimes;
            Console.WriteLine("2 candies for you.");

            candyMachine.ReleaseBall();
            candyMachine.ReleaseBall();
            int number = candyMachine.GetCandyNumber();

            if (number < 2)
            {
                candyMachine.SetState(candyMachine.GetSoldOutState());
            }
            else
            {
                candyMachine.SetState(candyMachine.GetNoQuarterState());
            }
        }
    }
}
