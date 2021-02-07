using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class PauseState : IState
    {
        public void DoAction(PlayButton button)
        {
            Console.WriteLine("Pause.");
            button.SetState(this);
        }
    }
}
