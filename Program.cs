/*
Created by Jaylink5353
Simple C# TicTacToe!!
*/

bool play = true;
Console.WriteLine("Simple C# Tic Tac Toe!");
Console.WriteLine("Made by Jaylink5353");

int game = 0;

while (play == true && game < +5)
{
    printGrid();
    game++;

}

void gameInit()
{
    
}
void printGrid()
{
    Console.WriteLine("   a     b     c ");
    Console.WriteLine("      |     |     ");
    Console.WriteLine($"1  -  |  -  |  -  ");
    Console.WriteLine("______|_____|_____");
    Console.WriteLine("      |     |     ");
    Console.WriteLine($"2  -  |  -  |  -  ");
    Console.WriteLine("______|_____|_____");
    Console.WriteLine("      |     |     ");
    Console.WriteLine($"3  -  |  -  |  -  ");
    Console.WriteLine("      |     |     ");
    
}
