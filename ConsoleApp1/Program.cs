// Application that simulates dice rolling
//Asks user to enter the number of sides on dice
//Make sure user can only enter numbers (exception handling)
//Prompts user to roll dice
//App rolls 2, X-sided die, displaying results of each with total score
//if its a 6 sided die, all recognizes dice combinations and outputs certain messages:
//Snake Eyes: Two 1s
//Ace Deuce: A 1 and 2
//Box Cars: Two 6s
//Win: A total of 7 or 11
//Craps: A total of 2, 3, or 12 (will also generate another message!)
//Asks user if they want to roll again

using System.ComponentModel.Design;
using System.Net.NetworkInformation;


int numberOfDieSides = 0;


Console.WriteLine("Welcome to the Dice Roll Game! Please enter how many sides the die should have: ");
while (int.TryParse(Console.ReadLine(), out numberOfDieSides) == false)
{
    Console.WriteLine("Please enter a number");
}

bool playAgain = true;
do
{
    int firstRoll = RollDice(numberOfDieSides);
    int secondRoll = RollDice(numberOfDieSides);
    string userResultsLower = ReturnUserScoreLower(firstRoll, secondRoll);
    string userResultsHigher = ReturnUserScoreHigher(firstRoll, secondRoll);
    Console.WriteLine($"You rolled a {firstRoll} and a {secondRoll}");
    Console.WriteLine(userResultsLower);
    Console.WriteLine(userResultsHigher);
    Console.WriteLine("Would you like to play again? Y/N");
    playAgain = Console.ReadLine().ToLower().Trim() == "y" ? true : false;
    if (playAgain == false)
    {
        Console.WriteLine("Thanks for playing!");
    }
} while (playAgain == true);


static int RollDice(int numberOfDieSides)
{
    Random randomRoll = new Random();
    int userRoll = randomRoll.Next(1, numberOfDieSides +1);   
    return userRoll;
}

static string ReturnUserScoreLower(int firstRoll, int secondRoll)
{
    if (firstRoll == 1 && secondRoll == 1)
    {
       return $"Snake eyes: Two 1's";
    }
    else if (firstRoll == 1 && secondRoll == 2)
    {
        return $"Ace Duece: A 1 and 2";
    }
    else if (firstRoll == 6 && secondRoll == 6)
    {
        return $"Box cars: Two 6's";
    }
   else
    {
        return "";
    } 
}

static string ReturnUserScoreHigher (int firstRoll, int secondRoll)
{
    if (firstRoll + secondRoll == 7)
    {
        return $"Win: Total of 7 or 11";
    }
    else if (firstRoll + secondRoll == 11)
    {
        return $"Win: Total of 7 or 11";
    }
    else if (firstRoll + secondRoll == 2)
    {
        return $"Craps: A total of 2, 3 or 12";
    }
    else if (firstRoll + secondRoll == 3)
    {
        return $"Craps: A total of 2, 3 or 12";
    }
    else if (firstRoll + secondRoll == 12)
    {
        return $"Craps: A total of 2, 3 or 12";
    }
    else
    {
        return "";
    }
}