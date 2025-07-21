/*
Created by Jaylink5353
Simple C# TicTacToe!!
*/

bool play = true;
Console.WriteLine("Simple C# Tic Tac Toe!");
Console.WriteLine("Made by Jaylink5353");

int game = 0;
Random random = new Random();
string userCoord = "xx";
int player = random.Next(1, 3);
//set coordinates

string a1 = "-";
string a2 = "-";
string a3 = "-";
string b1 = "-";
string b2 = "-";
string b3 = "-";
string c1 = "-";
string c2 = "-";
string c3 = "-";



while (play == true)
{
    printGrid();
    game++;

}


void printGrid()
{
    Console.WriteLine("   a     b     c ");
    Console.WriteLine("      |     |     ");
    Console.WriteLine($"1  {a1}  |  {a2}  |  {a3}  ");
    Console.WriteLine("______|_____|_____");
    Console.WriteLine("      |     |     ");
    Console.WriteLine($"2  {b1}  |  {b2}  |  {b3}  ");
    Console.WriteLine("______|_____|_____");
    Console.WriteLine("      |     |     ");
    Console.WriteLine($"3  {c1}  |  {c2}  |  {c3}  ");
    Console.WriteLine("      |     |     ");
    Thread.Sleep(500);
    Console.WriteLine("Type a coordinate!");
    cordPick();
}

void cordPick()
{
    string userInput = Console.ReadLine();
    if (userInput == "a1")
    {
        userCoord = "a1";
    }

    Console.WriteLine($"You've selected {userCoord}");
    Thread.Sleep(500);
    fillGrid();

}

void fillGrid()
{
    if (player == 1)
    {
        if (userCoord == "a1")
        {
            a1 = "X";
        }
    }
    else
    {
        if (userCoord == "a1")
        {
            a1 = "O";
        }
    }
    printGrid();
}