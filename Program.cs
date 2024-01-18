// Will Koelliker section 1
// This program simulates rolling two dice and adds the result together. 
// This result is then displayed in a * which represents 1% of the total numnber
// of rolls. This program has two classses a dicesimulator that prints out all the * and then 
// a RollDice simulator that generates a random number for each dice between 1 and 6.
// this result then gets added to an array that gets accessed in the diceSimulator class.

class DiceSimulator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        RollDice diceRoller = new RollDice();
        int[] results = diceRoller.SimulateRolls(numberOfRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");
        

        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / numberOfRolls;
            Console.WriteLine($"{i}: {new string('*', percentage)}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}

class RollDice
{
    private Random random;

    public RollDice()
    {
        random = new Random();
    }

    public int[] SimulateRolls(int numberOfRolls)
    {
        int[] results = new int[13];

        for (int i = 0; i < numberOfRolls; i++)
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            results[sum]++;
        }

        return results;
    }
}
