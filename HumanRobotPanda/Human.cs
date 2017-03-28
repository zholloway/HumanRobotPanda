using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRobotPanda
{
    class Human : Being, LivingFunctions
    {
        public bool SleepStatus { get; set; }

        public Human(string name)
        {
            this.Name = name;          
            Console.WriteLine($"{this.Name} the {this.GetType()} has been created.");
        }

        public override bool IsAsleep()
        {
            return SleepStatus;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{this.Name} eats the {food}.");
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
    }
}
