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

        public Robot(bool isATerminator)
        {
            this.TerminatorStatus = isATerminator;
            Console.WriteLine("Another superior being created. What is its name?");
            this.Name = Console.ReadLine();
            Console.WriteLine($"///BEEP BOOP {this.Name} HAS AWOKEN///");
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
            if (PowerOn == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
