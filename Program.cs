using Dice;

internal class Program
{
    private static void Main(string[] args)
    {
        Roll roll = new Roll();

        int[] results;
        int rolls;

        System.Console.WriteLine("Welcome to the dice throwing simulator!" +
            "\n\n" +
            "How many dice rolls would you like to simulate?");

        rolls = int.Parse(System.Console.ReadLine());

        results = roll.diceRoll(rolls);


        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS" +
            "\nEach \"*\" represents 1% of the total number of rolls." +
            "\nTotal number of rolls = " + rolls.ToString() + ".\n");

        for (int i = 0; i < 11; i++)
        {
            string asterisks = "";
            for (int x = 0; x < 100 * results[i] / rolls; x++)
            {
                asterisks += "*";
            }

            System.Console.WriteLine((i + 2).ToString() + ": " + asterisks);
        }


        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!\n\n\n");
    }
}

