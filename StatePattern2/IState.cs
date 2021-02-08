using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern2
{
    interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnQuarter(bool isWin);

        // Send out candy
        void Dispense();
    }
}
