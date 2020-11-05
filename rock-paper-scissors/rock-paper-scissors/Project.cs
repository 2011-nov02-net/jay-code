using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;

            while (playing) {
                Console.WriteLine("Input rock, paper, or scissors");
                playerChoice = Console.ReadLine();
                if (playerChoice == "rock" || playerChoice == "paper" || playerChoice == "scissors") {
                    GameRound(playerChoice);
                    Console.WriteLine("Play again? y/n");
                    playerChoice = Console.ReadLine();
                    if (playerChoice == "n") {
                        playing = false;
                    }
                }
            }
        }

        public static string playerChoice;

        private static List<string> CompChoice = new List<string>{"ROCK", "PAPER", "SCISSORS"};

        private static int playerScore;

        private static int computerScore;

        public static void GameRound(string player) {
            var playerIndex = 0;
            switch(player) {
                case "rock":
                    playerIndex = 0;
                    break;
                case "paper":
                    playerIndex = 1;
                    break;
                case "scissors":
                    playerIndex = 2;
                    break;
            }
            var random = new Random();
            var compIndex = random.Next(CompChoice.Count);
            var combinedIndex = (playerIndex, compIndex);
            var resultScreen = " " + $"Computer picked {CompChoice[compIndex]}." + " " + $"Player: {playerScore} vs Computer: {computerScore}" + " ";

            switch (combinedIndex) {    // (player choice, computer choice)
                case (0, 0):    // rock, rock
                case (1, 1):    // paper, paper
                case (2, 2):    // scissors, scissors
                    Console.Write("Tie!" + resultScreen);
                    break;
                case (0, 2):    // rock, scissors
                case (1, 0):    // paper, scissors
                case (2, 1):    // scissors, paper
                    Console.Write("You win!" + resultScreen);
                    playerScore++;
                    break;
                case (0, 1):    // rock, paper
                case (1, 2):    // paper, scissors
                case (2, 0):    // scissors, rock
                    Console.Write("You lose..." + resultScreen);
                    computerScore++;
                    break;
            }
        }
    }
}