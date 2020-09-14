using System;

namespace IterationsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an Integer between 1 and 20: ");


            try
            {
                string input = Console.ReadLine();
                //this will gather data from user

                int input_value = int.Parse(input);
                //this will hold our iterative statement value
                
                if ((input_value > 0) && (input_value <= 5))
                {
                    Console.WriteLine("Running the loop");
                    Console.WriteLine("Iterating loop " + input_value.ToString() + " times.");


                    //This is the loop
                    for (int x = 0; x < input_value; x++)
                    {
                        Console.WriteLine("The value of the variable X in this iterations is: " + x.ToString());
                    }
                    Console.WriteLine("Any key will exit this program");
                    //the program will wait for the user to close it
                    Console.ReadKey(true);
                }
                else if ((input_value > 5) && (input_value <= 10))
                {
                    Console.WriteLine("Executing a while loop");
                    Console.WriteLine("The while loop will iterate " + input_value.ToString() + " times.");

                    //while loop
                    while (input_value > 0)
                    {
                        Console.WriteLine("The value of the iterative variable is: " + input_value.ToString());
                        input_value--;

                    }
                    Console.WriteLine("Press any key to end the program");
                    Console.WriteLine(true);
                }
                else if ((input_value > 10) && (input_value <= 20))
                {
                    Console.WriteLine("Executing a while loop");
                    Console.WriteLine("The while loop will iterate " + input_value.ToString() + " times.");

                    //while loop
                    while (input_value > 0)
                    {
                        Console.WriteLine("The value of the iterative variable is: " + input_value.ToString());
                        input_value--;

                    }
                    Console.WriteLine("Press any key to end the program");
                    Console.WriteLine(true);
                }
                else
                {
                    //if the user doesnt enter a value between 1 and 20 error message
                    Console.WriteLine("Please enter an integer between 1 and 20");
                    Console.WriteLine("Press any key to exit and start again");
                    Console.ReadKey(true);


                }
                //end of try
            }
            catch
            {
                Console.WriteLine("Please enter and integer value and try running the program again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
        }
    }
}
