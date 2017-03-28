using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanRobotPanda
{
    class Program
    {
        static void Main(string[] args)
        {
            //create humans
            var peter = new Human("Peter");
            var mary = new Human("Mary");

            //human check
            peter.DisplayGreeting();
            mary.GoToSleep();
            mary.IsAsleep();

            //create pandas
            var mrFuzzy = new Panda("Mr.Fuzzy");
            var ecoBear = new Panda("Recycla");

            //panda check

            //create robots
            var robut1 = new Robot("R2D2", false);
            var robut2 = new Robot("GLORNOK", true);

            //robot check

            //create lists
            var everything = new List<Being>
            {
                peter, mary, mrFuzzy, ecoBear, robut1, robut2
            };

            var livingThings = new List<ILivingFunctions>();

            foreach (var being in everything)
            {
                if (being.GetType().Name.ToString() != "Robot")
                {
                   
                    livingThings.Add(being as ILivingFunctions);
                }
            }

            foreach (var being in livingThings)
            {
                Being individual = being as Being;
                Console.WriteLine(individual.Name);
            }

            Console.ReadLine();
        }
    }
}
