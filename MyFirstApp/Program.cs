using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weapons = { "Rock", "Paper", "Scissors" };
            int bestOfCounter = 1;
            int playerWeapon = -1;
            int playerWins = 0;
            int computerWins = 0;
            string playAgain = null;
            string bestOf = null;
            string playerInput = null;
            string playerChoice = null;

            Console.WriteLine("**********************************");
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Program.instructionsForRockPaperScissors();

            while (playAgain != "NO" && playAgain != "N")
            {
                playAgain = null;
                while (bestOf != "Y" && bestOf != "N")
                {
                    Console.WriteLine("\nWould you like to play a \"best-of\" match?");
                    string yesNo = Console.ReadLine();
                    bestOf = yesNo.ToUpper();
                    if (bestOf != "Y" && bestOf != "N")
                    {
                        Console.WriteLine("\nNot a valid input, try again.");
                        Console.WriteLine("******************************");
                    }
                }
                if (bestOf == "Y")
                {
                    Console.WriteLine("How many rounds do you want to play?");
                    bestOfCounter = Convert.ToInt32(Console.ReadLine());
                }
                for (int roundTicker = 0; roundTicker < bestOfCounter;)
                {
                    if (playerWins > bestOfCounter / 2 || computerWins > bestOfCounter / 2)
                    {
                        break;
                    }
                    playerChoice = null;
                    Console.WriteLine("\n**********************************");
                    while (playerChoice != "R" && playerChoice != "P" && playerChoice != "S" && playerChoice != "ROCK" && playerChoice != "PAPER" && playerChoice != "SCISSORS")
                    {
                        Console.Write("Choose your weapon!  ");
                        playerInput = Console.ReadLine();
                        playerChoice = playerInput.ToUpper();
                        if (playerChoice != "R" && playerChoice != "P" && playerChoice != "S" && playerChoice != "ROCK" && playerChoice != "PAPER" && playerChoice != "SCISSORS")
                        {
                            Console.Write($"\n{playerChoice} is not a valid input.");
                            Console.Write("\nPlease try again with Rock, Paper, or Scissors.");
                            Console.WriteLine("\n**********************************");
                        }
                    }
                    if (playerChoice == "R" || playerChoice == "ROCK")
                    {
                        playerWeapon = 0;
                    }
                    else if (playerChoice == "P" || playerChoice == "PAPER")
                    {
                        playerWeapon = 1;
                    }
                    else if (playerChoice == "S" || playerChoice == "SCISSORS")
                    {
                        playerWeapon = 2;
                    }
                    Console.WriteLine($"You chose: {weapons[playerWeapon]}!");
                    Random choice = new Random();
                    int computerWeapon = choice.Next(3);
                    Console.WriteLine($"I choose: {weapons[computerWeapon]}!");
                    if ((playerWeapon == 0 && computerWeapon == 2) || (playerWeapon == 1 && computerWeapon == 0) || (playerWeapon == 2 && computerWeapon == 1))
                    {
                        Console.WriteLine("\nNice one! That point is yours.");
                        playerWins++;
                        Console.WriteLine($"\nYour score is:" + playerWins);
                        Console.WriteLine($"My score is:" + computerWins);
                        roundTicker++;
                    }
                    else if ((playerWeapon == 0 && computerWeapon == 1) || (playerWeapon == 1 && computerWeapon == 2) || (playerWeapon == 2 && computerWeapon == 0))
                    {
                        Console.WriteLine("\nI'll take that point!");
                        computerWins++;
                        Console.WriteLine($"\nYour score is:" + playerWins);
                        Console.WriteLine($"My score is:" + computerWins + "\n");
                        roundTicker++;
                    }
                    else
                    {
                        Console.WriteLine("\nDarn. It's a tie. \n");
                    }
                }
                if (playerWins > computerWins)
                {
                    Console.WriteLine("**********************************");
                    Console.WriteLine("\nYou're so good at this!  You won!");
                }
                else if (computerWins > playerWins)
                {
                    Console.WriteLine("**********************************");
                    Console.WriteLine("\nBetter luck next time!");
                }
                else
                {
                    Console.WriteLine("**********************************");
                    Console.WriteLine("\nI guess we'll never know who's better.");
                }
                while (playAgain != "YES" && playAgain != "Y" && playAgain != "NO" && playAgain != "N")
                {
                    Console.WriteLine("\nWould you like to play again?");
                    string playAgainCount = Console.ReadLine();
                    playAgain = playAgainCount.ToUpper();
                    if (playAgain != "YES" && playAgain != "Y" && playAgain != "NO" && playAgain != "N")
                    {
                        Console.Write($"\n{playAgain} is not a valid input.");
                        Console.Write("\nYou must answer \"Yes\" or \"No\"");
                        Console.WriteLine("\n**********************************");
                    }
                    else if (playAgain == "NO" || playAgain == "N")
                    {
                        Console.WriteLine("\nThanks for playing!");
                        break;
                    }
                    else
                    {
                        playerWins = 0;
                        computerWins = 0;
                    }
                }
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
            return;
        }

        static void instructionsForRockPaperScissors()
        {
            string instructionsNeeded = null;

            while (instructionsNeeded != "Y" && instructionsNeeded != "N")
            {
                Console.WriteLine("Do you need instructions?");
                string instructions = Console.ReadLine();
                instructionsNeeded = instructions.ToUpper();
                if (instructionsNeeded != "Y" && instructionsNeeded != "N")
                {
                    Console.WriteLine("\nPlease choose either \"Yes\" or \"No\".");
                    Console.WriteLine("\n******************************");
                }
            }
            if (instructionsNeeded == "Y" || instructionsNeeded == "YES")
            {
                Console.WriteLine("\nThis game consists of three types of questions.");
                Console.WriteLine("\tYes/No questions can be answered with any of the following:");
                Console.WriteLine("\t-Yes can be entered as either \"Yes\" or \"Y\"");
                Console.WriteLine("\t-Yes can be entered as either \"No\" or \"N\"");
                Console.WriteLine("");
                Console.WriteLine("The game may ask you for a number of rounds.  This must be a number.");
                Console.WriteLine("\tWhen asked to \"Choose your weapon!\" you may pick any of the following:");
                Console.WriteLine("\t-\"Rock\" or \"R\"");
                Console.WriteLine("\t-\"Paper\" or \"P\"");
                Console.WriteLine("\t-\"Scissors\" or \"S\"");
                Console.WriteLine("");
                Console.WriteLine("Don't worry, these choices are not case-sensitive!");
                Console.WriteLine("");
                Console.WriteLine("Once you have finished reading, please press any key to continue.");
                Console.ReadKey();
            }

        }
    }
}

