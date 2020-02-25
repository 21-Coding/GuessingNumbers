using System;
using System.Collections.Generic;


namespace greaterGame
{
    public class Level
    {
              public int Upper;
              public int Lower;
              public int Current;
           public Level(int upper, int lower, int current)
            {
                Upper = upper;
                Lower = lower;
                Current = current;
            }

        static void Main()
        {

            Console.WriteLine("What is the upper limit of your number?");
            string upper = Console.ReadLine();
            int intUpper = int.Parse(upper);

            Console.WriteLine("What is the lower limit of your number?");
            string lower = Console.ReadLine();
            int intLower = int.Parse(lower);

            int intCurrent = (intUpper - (intUpper -  intLower)/2);
            // int intUser = int.Parse(userInput);

            
            Level userLevel = new Level(intUpper, intLower, intCurrent);
            Console.WriteLine("userLevel.intLower: " + userLevel.Lower);
            Console.WriteLine("userLevel.Upper: " + userLevel.Upper);
            Console.WriteLine("userLevel.Current: " + userLevel.Current);


            GuessingGame();
        
        void GuessingGame()
        {
            Console.WriteLine("Is your number greater than, less then, or equal to: " + userLevel.Current + "?");
            string userAnswer = Console.ReadLine().ToLower();
            if (userAnswer.Contains("greater") || userAnswer.Contains("higher") || userAnswer.Contains("more"))
            {
                userLevel.Lower = userLevel.Current;
                userLevel.Current = (userLevel.Upper - (userLevel.Upper -  userLevel.Lower)/2);
                GuessingGame();
            }
            else if (userAnswer.Contains("less") || userAnswer.Contains("lower"))
            {
                userLevel.Upper = userLevel.Current;
                userLevel.Current = (userLevel.Upper - (userLevel.Upper -  userLevel.Lower)/2);
                GuessingGame();
            }
            else if (userAnswer.Contains("equals"))
            {
                Console.WriteLine("Your number was: " + userLevel.Current + "!");
            }
        }
        }

    }
}
