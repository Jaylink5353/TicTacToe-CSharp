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
//int player = random.Next(1, 3);
int player = 1;
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

bool picked = false;



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
    userInput();
}

void userInput()
{
    userCoord = Console.ReadLine();
    if (userCoord == "q")
    {
        Console.WriteLine("Thanks for playing! Goodbye!");
        play = false;
    }
    Console.WriteLine($"You've selected {userCoord}");
    Thread.Sleep(500);
    fillGrid();

}

void fillGrid()
{
    if (player == 1)
    {
        if (userCoord.Contains("a") || userCoord.Contains("A"))
        {
            if (userCoord.Contains("1"))
            {
                a1 = "X";
                picked = true;
            }
            if (userCoord.Contains("2"))
            {
                a2 = "X";
                picked = true;
            }
            if (userCoord.Contains("3"))
            {
                a3 = "X";
                picked = true;
            }
            else if (picked == false)
            {
                Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
                Thread.Sleep(500);
                printGrid();
            }
        }
        if (userCoord.Contains("b") || userCoord.Contains("B"))
        {
            if (userCoord.Contains("1"))
            {
                b1 = "X";
                picked = true;
            }
            if (userCoord.Contains("2"))
            {
                b2 = "X";
                picked = true;
            }
            if (userCoord.Contains("3"))
            {
                b3 = "X";
                picked = true;
            }
            else if (picked == false)
            {
                Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
                Thread.Sleep(500);
                printGrid();
            }
        }
        if (userCoord.Contains("c") || userCoord.Contains("C"))
        {
            if (userCoord.Contains("1"))
            {
                c1 = "X";
                picked = true;
            }
            if (userCoord.Contains("2"))
            {
                c2 = "X";
                picked = true;
            }
            if (userCoord.Contains("3"))
            {
                c3 = "X";
                picked = true;
            }
            else if (picked == false)
            {
                Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
                Thread.Sleep(500);
                printGrid();
            }
        }
        else if (picked == false)
            {
                Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
                Thread.Sleep(500);
                printGrid();
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