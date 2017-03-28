using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRobotPanda
{
    class Being
    {
        public string Name { get; set; }

        public bool IsAsleep { get; set; }

        public Being()
        {
        }

        public virtual void DisplayName()
        {
            Console.WriteLine(this.Name);
        }

        public virtual void DisplayGreeting()
        {
        }
    }
}
