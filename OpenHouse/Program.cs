//OpenHouse: 
//1)	User that’s visiting an open house
//2)	Prompt user to visit rooms
//3)	Optionally visit rooms
//a)	Ask about things in the room
//b)	Optionally describe things
//4)	The above, but continued w/Open House aspects

using System;

namespace OpenHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our open house!");

            bool continueCheck = false;            

            do
            {
                continueCheck = false;
                Console.WriteLine("Are you ready to have a look around?");
                
                if (Console.ReadLine().ToUpper()[0] == 'N')
                {
                    continueCheck = true;
                    Console.WriteLine("Let me know if you change your mind. I will be right here.");
                }
            } while (continueCheck);

            Console.WriteLine("Excellent, we will start with the kitchen.\nAs you can see most of the kitchen was recently renovated.");

            Console.WriteLine("Do you cook most meals or order out?");
            string cook = Console.ReadLine();
            if (cook.ToUpper()[0] == 'C')
            {
                Console.WriteLine("In that case I'm sure you will love the new stove and oven.");
            }
            else
            {
                Console.WriteLine("In that case you will be happy to know there are many great delivery options in this area.");
            }

            Console.WriteLine("Do you have a large family?");
            string largeFamily = Console.ReadLine();

            if (largeFamily.ToUpper()[0] == 'Y')
            {
                Console.WriteLine("Lets move to the dining room where you will be able to have everyone together for big meals.");
            }
            else
            {
                Console.WriteLine("Lets move to the basement that could be turned in to a game room or office if you like.");
            }

            Console.WriteLine("If you look out the window you will see the large backyard with a pool for the sumer and a fire pit for the winter.");

            do
            {
                continueCheck = false;
                Console.WriteLine("Are you ready to move on to the master bedroom?");
                string answer = Console.ReadLine();
                if (answer.ToUpper()[0] == 'N')
                {
                    continueCheck = true;
                    Console.WriteLine("It sure is a nice view. Just let me know when you are ready.");
                }
            } while (continueCheck);

            Console.WriteLine("As you can see there are two walk in closets and a large master bathroom.");

            Console.WriteLine("Would you like to see the garage?");
            string garage = Console.ReadLine();

            if (garage.ToUpper()[0] == 'Y')
            {
                Console.WriteLine("There is room for two cars and also plenty of storage space should you need it");
            }
            else
            {
                Console.WriteLine("That will wrap up the tour. Thank you so much for coming!");
            }
            Console.ReadLine();
        }

    }
}
