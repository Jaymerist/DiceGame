/*
 * Purpose: Demonstrate class level methods using a simple Die class
 * Input: Die.cs
 * Output: wins, losses, ties, games played
 * Author: Mihiri Kamiss
 * Date: November 9, 2022
 */

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //declare variables
                Die computerDie1 = new Die(),
                    computerDie2 = new Die(),
                    playerDie1 = new Die(),
                    playerDie2 = new Die();
                int playerRoll,
                    computerRoll,
                    playerWins = 0,
                    computerWins = 0,
                    ties = 0,
                    gamesPlayed = 0;
                string message;
                char rollAgain;

                //game loop
                do
                {
                    computerDie1.Roll();
                    computerDie2.Roll();
                    playerDie1.Roll();
                    playerDie2.Roll();

                    //add the dice
                    playerRoll = playerDie1.AddDie(playerDie2);
                    computerRoll = computerDie1.AddDie(computerDie2);

                    //display the dice
                    DisplayRoll(playerDie1, playerDie2, "Player");
                    DisplayRoll(computerDie1, computerDie2, "Computer");

                    //determine winner or a tie
                    if (playerRoll > computerRoll)
                    {
                        playerWins++;
                        message = "Player wins";
                    }
                    else if (playerRoll < computerRoll)
                    {
                        computerWins++;
                        message = "Computer wins";
                    }
                    else
                    {
                        ties++;
                        message = "it's a tie";
                    }

                    gamesPlayed++;
                    Console.WriteLine(message);

                    //prompt to roll again
                    Console.Write("\nRoll again (Y): ");
                    rollAgain = char.Parse(Console.ReadLine().ToUpper().ToUpper().Substring(0, 1));

                } while (rollAgain == 'Y');

                //display game summary 
                Console.WriteLine($"\n{gamesPlayed} games played:\nPlayer Wins: {playerWins}\nComputer Wins: {computerWins}\nTies: {ties}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            

            Console.ReadLine();
        }//end of Main

        static void DisplayRoll(Die die1, Die die2, string player)
        {
            Console.WriteLine($"{player,8}'s roll was: {die1.Facevalue} and {die2.Facevalue}"); 
        }


    }
}