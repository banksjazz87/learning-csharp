using System.IO.Pipelines;
using System;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        Random rand = new Random();
        int target = rand.Next(1, 5);
        int roll = rand.Next(1, 5);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    var response = Console.ReadLine();

    if (response != null && response.ToLower() == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

string WinOrLose(int target, int roll)
{
    if (roll > target)
    {
        return "Congratulations, you won!";
    }
    else
    {
        return "Don't quit your day job, you just lost!";
    }
}