// Build Dice Game
Console.WriteLine("====Simple Dice Game====/nType 'Start' 'S' to roll the die:");

string startGame = Console.ReadLine()!;

if (!(startGame.Equals("Start",StringComparison.OrdinalIgnoreCase) || startGame.Equals("s", StringComparison.OrdinalIgnoreCase)))
{
    Console.WriteLine("Enter 'Start' or 'S' to start the game properly");
    return;
}

Random random = new();
int diceOne = random.Next(1, 7);
int diceTwo = random.Next(1, 7);
int diceThree = random.Next(1, 7);
int originalScore = diceOne + diceTwo + diceThree;
const int DOUBLE_POINT = 2;
const int TRIPLE_POINT = 6;
int totalPoint = originalScore;

if (diceOne == diceTwo && diceTwo == diceThree)
{
    totalPoint += TRIPLE_POINT;

    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou rolled a triple! You have a total of {totalPoint} points");
}
else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
{
    totalPoint += DOUBLE_POINT;

    Console.WriteLine($"Dice One {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou rolled a double! You have a total of{totalPoint} Points");
}
else
{
    Console.WriteLine($"Dice One {diceOne}\nDice Two:{diceTwo}\nDice Three: {diceThree}.\nYou have a total of {totalPoint} Points");
}

 if (totalPoint >= 10 && totalPoint <= 13)
{
    Console.WriteLine("Congratulation!,you won a ballon!");
}

else if (totalPoint >= 14 && totalPoint <= 16)
{
    Console.WriteLine("Congratulation!,you won a Exercise Book");
}

else if (totalPoint >= 17)
{
    Console.WriteLine("Congratulation!,you won a 5000 MAH PowerBank");
}

else if (totalPoint >= 21)
{
    Console.WriteLine("Congratulation!,you are lucky and you won a Samsung S23 Ultra");
}

else if (totalPoint >= 18 && totalPoint <= 20)
{
    Console.WriteLine("Congratulation!,you won a Ticket to SilverBird Cinema");
}

else if (totalPoint >= 22 && totalPoint >= 24)
{
    Console.WriteLine("Congratulation!,you won all the Item");
}

else
{
    Console.WriteLine("Sorry Try Again Later!");
}
