// Roger Dominguez, 
//This program is to display a for loop iteration

using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // The user enters their input
            Console.WriteLine("Enter and integer value between 1 and 100: ");
            // The console reads their input
            string input = Console.ReadLine();
            // The value of the input is declared and int
            int value_of_input = int.Parse(input);
            // the if value parameters are set
            if ((value_of_input > 0) && (value_of_input <= 100))
            {
                // The iteration addition here is added for every amount requested
                Console.WriteLine("Executing a For Loop!");
                Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times.");
                // The loop is establisehd here adding to the value of input based off of input + i
                for (int i = 0; i < value_of_input; i++)
                {
                    // The console reads the final results
                    Console.WriteLine("The value of the variable i in this iteration is " + i.ToString());
                }
                // Ends program and VS studios brings up exit command
                Console.ReadKey(true);
            }
        }
    }
}
