using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRobotPanda
{
    interface ILivingFunctions
    {
        void Eat(string food);

        void GoToSleep();

        void WakeUp();
    }
}
