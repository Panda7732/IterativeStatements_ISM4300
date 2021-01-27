/*
 * Name:Amanda Hernandez
 *Date:1/26/2021
 *Descriprion: ISM 4300 Deliverable 2 - Iterative Statements
 */

using System;

namespace IterativeStatements_ISM4300
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user to enter value
            Console.WriteLine("Enter integer value between 1 and 100.");

            //use try-catch statement to ensure only integer values are used
            try
            {
                //Gather input and assin as int
                string input = Console.ReadLine();
                int value = int.Parse(input);
                //set count equal to value
                int count = value;
                //limit value entered to 1-100
                if(value<1 || value >100)
                {
                    Console.WriteLine("Please enter an integer value between 1-100");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);

                }

                //limit count to 100
                while (count < 100)
                {
                    //Show message of what value was input and what count in the loop
                    Console.WriteLine("You have entered" + " " + value.ToString() + ".The current integer value in the loop is" + " " + count.ToString());
                   //Add 1 to counter each iteration
                    count++;
                }

            }
            //end of try
            catch
            {
                //tell user to type integer when they put noninteger characters
                Console.WriteLine("Please enter an integer value between 1-100");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            }
            //end of catch
        }
    }
}
