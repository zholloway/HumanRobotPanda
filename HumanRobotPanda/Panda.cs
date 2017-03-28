using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRobotPanda
{
    class Panda : Being, ILivingFunctions
    {
        private bool SleepStatus { get; set; }

        public Panda(string name)
        {
            this.Name = name;
            Console.WriteLine($"{this.Name} the {this.GetType().Name} has been created.");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{this.Name} eats the {food}.");
        }

        public override bool IsAsleep()
        {
            return SleepStatus;
        }

        public void GoToSleep()
        {
            this.SleepStatus = true;
            Console.WriteLine($"{this.Name} went to sleep!");
        }

        public void WakeUp()
        {
            this.SleepStatus = false;
            Console.WriteLine($"{this.Name} woke up!");
        }

        public override void DisplayGreeting()
        {
            Console.WriteLine($"{this.Name} yawns and waves at you :)");
        }
    }
}
