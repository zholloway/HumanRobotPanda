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

        public virtual string DisplayName()
        {
            return this.Name;
        }

        public virtual void DisplayGreeting(){}

        public void DisplayType()
        {
            Console.WriteLine($"{this.Name} is a {this.GetType().Name}.");
        }

        public virtual bool IsAsleep()
        {
            return true;
        }
    }
}
