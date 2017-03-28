using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRobotPanda
{
    abstract class Being
    {
        public string Name { get; set; }

        public Being(){}

        public virtual void DisplayName()
        {
            Console.WriteLine(this.Name);
        }

        public virtual void DisplayGreeting(){}

        public void DisplayType()
        {
            Console.WriteLine($"{this.Name} is a {this.GetType()}.");
        }

        public virtual bool IsAsleep()
        {
            return true;
        }
    }
}
