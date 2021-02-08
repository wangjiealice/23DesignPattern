using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StatePattern2
{
    class CandyMachine
    {
        IState noQuarterState;
        IState hasQuarterState;
        IState soldOutState;
        IState soldState;
        IState winnerState;

        IState currentState;
        int totalNumber;
        int ballNumber;
        List<int> winTimes;
        public int CurrentTurnTimes { get; set; }

        public CandyMachine(int totalBallNumber)
        {
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldOutState = new SoldOutState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            currentState = soldOutState;

            ballNumber = totalBallNumber;
            totalNumber = totalBallNumber;
            CurrentTurnTimes = 0;

            if (ballNumber > 1)
            {
                currentState = noQuarterState;
            }

            winTimes = GetWinTime();
        }

        private List<int> GetWinTime()
        {
            // To lower
            int turnTimes = (int)(totalNumber * 0.9);
            int winTimes = (int)(totalNumber * 0.1);
            Random rd = new Random();
            List<int> times = new List<int>();

            for(int i =0; i < winTimes; i++)
            {
                int time = rd.Next(1, turnTimes);
                Console.WriteLine("Win time is {0}.", time);
                times.Add(time);
            }

            return times;
        }

        public void EjectQuarter()
        {
            currentState.EjectQuarter();
        }

        public void InsertQuarter()
        {
            currentState.InsertQuarter();
        }

        public void TurnQuarter()
        {
            if (winTimes.Where(item => item.Equals(CurrentTurnTimes)).Count() > 0)
            {
                currentState.TurnQuarter(true);
            }
            else
            {
                currentState.TurnQuarter(false);
            }

            currentState.Dispense();
        }

        public void SetState(IState state)
        {
            currentState = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            --ballNumber;
        }

        public int GetCandyNumber()
        {
            return ballNumber;
        }

        //public void SetCandyNumber(int number)
        //{
        //    ballNumber = number;
        //}

        public int GetAllCandyNumber()
        {
            return totalNumber;
        }

        public IState GetNoQuarterState()
        {
            return noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return hasQuarterState;
        }

        public IState GetSoldOutState()
        {
            return soldOutState;
        }

        public IState GetSoldState()
        {
            return soldState;
        }

        public IState GetWinnerState()
        {
            return winnerState;
        }
    }
}
