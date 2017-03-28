using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRobotPanda
{
    class Robot : Being
    {
        private bool PowerOn { get; set; }

        private bool TerminatorStatus { get; set; }

        public bool IsTerminator()
        {
            return this.TerminatorStatus;
        }

        public Robot(string name, bool isATerminator)
        {
            this.TerminatorStatus = isATerminator;
            this.Name = name;
            Console.WriteLine("Another superior being created.");
            Console.WriteLine($"///BEEP BOOP {name} HAS AWOKEN///");
        }

        public void StartUp()
        {
            this.PowerOn = true;
            Console.WriteLine($"{this.Name} has powered on!");
        }

        public void ShutDown()
        {
            this.PowerOn = false;
            Console.WriteLine($"{this.Name} has powered off.");
        }

        public override bool IsAsleep()
        {
            return PowerOn;
        }

        public override void DisplayGreeting()
        {
            Console.WriteLine($"///I AM {this.Name}. I WILL DESTROY YOU, HUMAN.///");
        }
    }
}
