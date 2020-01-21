using System;

namespace Lab_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Human. I am the room Calculator.");
            Console.WriteLine("I will need a few things from you. I will need the Height, Lengt, & Width");

            bool doAgain = true;
            bool comeAgain = true;
            do
            {

                Console.Write("Please enter the Length of the room. ");
                string inputLength = Console.ReadLine();
                double trueLength = double.Parse(inputLength);

                Console.Write("Please enter the Width of the room. ");
                string inputWidth = Console.ReadLine();
                double trueWidth = double.Parse(inputWidth);

                Console.Write("Please enter the Length of the room. ");
                string inputHeight = Console.ReadLine();
                double trueHeight = double.Parse(inputHeight);

                Console.Clear();

                double area = (trueLength * trueWidth);
                double perimeter = ((2 * trueLength) + (2 * trueWidth));
                double volume = (trueHeight * trueLength * trueWidth);
                string roomNumbers = $"The area of this room is: {area}sq feet \nThe perimeter is:{perimeter}feet \nThe volume is: {volume} cubic feet.";

                if (area <= 250)
                {
                    Console.WriteLine($"{roomNumbers} \nThis is a small sized room");
                }
                else if ((area < 650) && (area > 250))
                {
                    Console.WriteLine($"{roomNumbers} \nThis is a medium sized room");
                }
                else /* if (area > 650) */
                {
                    Console.WriteLine($"{roomNumbers} \nThis is a large sized room");
                }

                do
                {

                    Console.Write("Would you like to calculate another room? Yes or No ");
                    string doAgainInput = Console.ReadLine().ToLower();
                
                    if ((doAgainInput == "yes") || (doAgainInput == "y"))
                    {
                        doAgain = true;
                        comeAgain = false;
                    }
                    else if ((doAgainInput == "no") || (doAgainInput == "n"))
                    {
                        doAgain = false;
                        comeAgain = false;
                        Console.WriteLine("Have a great day");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("I am sorry. I did not understand that.");
                        comeAgain = true;
                    }
                } while (comeAgain == true);


            } while (doAgain == true);
        }
    }
}
