// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
Console.Write("Choose [r}ock ,[p]aper or [s]cissors: ");
string playerMove = Console.ReadLine();
if (playerMove == "r" || playerMove == "rock")
{
    playerMove = Rock;
}
else if (playerMove == "p" || playerMove == "paper")
{
    playerMove = Paper;
}
else if (playerMove == "s" || playerMove == "scissors")
{
    playerMove = Scissors;
}
else
{
    Console.WriteLine("Invalid input!");
}
//choosing a random number
Random random = new Random();
int compRandomNum = random.Next(1, 4);

string computerMove = "abc";
switch (compRandomNum)
{
    case 1:
        computerMove ="Rock";
        break;
    case2:
        computerMove = "Paper";
        break;
    case 3:
        computerMove = "Scissors";
        break;
}
string winner = "YOU";
if (( computerMove == Rock && playerMove==Scissors)||
   (computerMove == Scissors && playerMove == Paper)||
   (computerMove == Paper && playerMove == Rock) )
{ winner = "THE COMPUTER"; }
Console.WriteLine($"You choosed {playerMove}, the computer choosed {computerMove}, so the winner is {winner}");
