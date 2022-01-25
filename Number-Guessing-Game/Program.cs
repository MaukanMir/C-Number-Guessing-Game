using System;
using System.Linq;
using System.Collections.Generic;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main()
        {
            int lives = 10;

            IntroDuction();

            string name = GrabUserInfo();

            Console.WriteLine("Hello {0}! Welcome to the Number Guessing Game!",name);

            int correctGuess = GenerateGuess();

            int userGuess = UserGuess();

            string result = CheckAns(correctGuess, userGuess);

            Console.WriteLine(result);
            lives -= 1;
            Console.WriteLine(CheckLives(lives));
            
            while ( result != "Congrats you have Won!" && lives >0)
            {
                userGuess = UserGuess();
                result = CheckAns(correctGuess, userGuess);
                Console.WriteLine(result);
                if(result == "Congrats you have Won!")
                {
                    break;
                }
                lives -= 1;
                Console.WriteLine(CheckLives(lives));
                
            }



            string replayGame = Redo();

            if(replayGame == "Starting Console...")
            {
                Main();
            }
            else { Console.WriteLine(replayGame);}

        }

      
        public static void IntroDuction()
        {
            string appName = "Number Guessing Game";
            string appVersion = "18.0.0";
            string appCreator = "Maukan Mir";

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("{0}: Version: {1} Created by {2}", appName, appVersion, appCreator);

            Console.ResetColor();

        }

        public static int GenerateGuess()
        {
            Random got = new Random();
            int correctGuess = got.Next(0, 100);
            return correctGuess;
        }

        public static string GrabUserInfo()
        {
            Console.WriteLine("Please Input Your Name Below");
            string input = Console.ReadLine();
            return input;
        }

        public static int UserGuess()
        {
            Console.WriteLine("Please make a guess between 1 to 100");
            string guess = Console.ReadLine();
            int checkAns = Convert.ToInt32(guess);
            return checkAns;
        }

        public static string CheckAns(int comp,int user)
        {
            if (user == comp)
            {
                return "Congrats you have Won!";
            }

           
            return user > comp ? "Too High" : "Too Low";
        }

        public static string CheckLives(int lives)
        {
            
            return lives > 0 ? String.Format("You have {0} live(s) remaining", lives): "Game Over";
        }


        public static string Redo()
        {
            Console.WriteLine("Would you like to play again? Enter 'Yes' to continue or 'No' to end the game.");

            string answer = Console.ReadLine();
            return answer == "Yes" ? "Starting Console..." : "Thank you for Playing";
        }

    }
}
