using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_Programming_Challenge_1___102698672
{
    class Program
    {
        public static void Main(string[] args)
        {

            int Dicevalue;
            int Rollcount = 0;
            Random random = new Random();
            Dicevalue = random.Next(1, 6);
            bool yes = true;
            bool no = false;
            string uinput = string.Empty;
            List<int> numbers = new List<int>();

          
            Console.WriteLine("Let's Roll Some Dice!");
            Console.WriteLine();

            while (yes)
            {
             
                Console.WriteLine("Roll Dice? (yes or no)");
                Console.WriteLine();

                uinput = Console.ReadLine();
                Console.WriteLine();

                if (uinput.ToLower() == "yes")
                {
                   
                    Console.WriteLine(Dicevalue);
                    numbers.Add(Dicevalue);
                    
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Total = ");
                    Console.WriteLine("Average = ");
                    Console.WriteLine("Rolls = ");
                    Console.WriteLine();
                }


            }



            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();

        }

    }
}