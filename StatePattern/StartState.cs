using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class StartState : IState
    {
        public void DoAction(PlayButton button)
        {
            Console.WriteLine("Start.");
            button.SetState(this);
        }
    }
}
