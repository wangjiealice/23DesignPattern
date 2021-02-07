using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class PlayButton
    {
        IState currentState;

        public PlayButton() 
        {
            currentState = new StartState();
        }


        public IState GetState()
        {
            return currentState;
        }

        public void SetState(IState state)
        {
            currentState = state;
        }
    }
}
