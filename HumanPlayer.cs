using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
           Console.WriteLine("Please enter a number between 1 and 6:");
           int validInput;
           bool isNum = int.TryParse(Console.ReadLine(), out validInput);
           if(isNum && validInput > 0 && validInput < 7)
           {
               return validInput;
           }
           else
           {
               Console.WriteLine("ERROR!!!! Please enter a valid number between 1 and 6");
                return Roll();           
           }
        }
    }
}