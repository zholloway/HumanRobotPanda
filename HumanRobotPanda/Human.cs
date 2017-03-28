using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRobotPanda
{
    class Human : Being, ILivingFunctions
    {
        public bool SleepStatus { get; set; }

        public Human(string name)
        {
            this.Name = name;          
            Console.WriteLine($"{this.Name} the {this.GetType().Name} has been created.");
        }

        public override bool IsAsleep()
        {
            return SleepStatus;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Yum, I ate {food}.");
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
            Console.WriteLine($"Hey there! My name is {this.Name}.");
        }
    }
}
