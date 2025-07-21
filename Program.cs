/*
Created by Jaylink5353
Simple C# TicTacToe!!
*/

bool play = true;
Console.WriteLine("Simple C# Tic Tac Toe!");
Console.WriteLine("Made by Jaylink5353");

string help = "Input your desired cordinate (for example, a1). Type n for a new game, h to print this, or q to exit.";
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
bool picked = false;
int spacesOccupied = 0;
string xOrO = "N";

void newGame()
{
    player = random.Next(1, 3);
    a1 = "-";
    a2 = "-";
    a3 = "-";
    b1 = "-";
    b2 = "-";
    b3 = "-";
    c1 = "-";
    c2 = "-";
    c3 = "-";
    picked = false;
    userCoord = "xx";
    spacesOccupied = 0;
}


//main loop
Console.WriteLine(help);
while (play == true)
{
    printGrid();
}


void printGrid()
{
    userCoord = "xx";
    Console.WriteLine("   1     2     3 ");
    Console.WriteLine("      |     |     ");
    Console.WriteLine($"a  {a1}  |  {a2}  |  {a3}  ");
    Console.WriteLine("______|_____|_____");
    Console.WriteLine("      |     |     ");
    Console.WriteLine($"b  {b1}  |  {b2}  |  {b3}  ");
    Console.WriteLine("______|_____|_____");
    Console.WriteLine("      |     |     ");
    Console.WriteLine($"c  {c1}  |  {c2}  |  {c3}  ");
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
        Environment.Exit(0);
    }
    if (userCoord == "n")
    {
        Console.WriteLine("New Game");
        Thread.Sleep(1000);
        newGame();
        printGrid();

    }
    if (userCoord == "h")
    {
        Console.WriteLine($"{help} Press any key to continue.");
        Console.ReadKey();
        printGrid();
    }
    Console.WriteLine($"You've selected {userCoord}");
    Thread.Sleep(500);
    fillGrid();
    

}

void fillGrid()
{
    picked = false;
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
                Thread.Sleep(1500);
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
                Thread.Sleep(1500);
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
                Thread.Sleep(1500);
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
    else if (player == 2)
    {
        if (userCoord.Contains("a") || userCoord.Contains("A"))
        {
            if (userCoord.Contains("1"))
            {
                a1 = "O";
                picked = true;
            }
            if (userCoord.Contains("2"))
            {
                a2 = "O";
                picked = true;
            }
            if (userCoord.Contains("3"))
            {
                a3 = "O";
                picked = true;
            }
            else if (picked == false)
            {
                Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
                Thread.Sleep(1500);
                printGrid();
            }
        }
        if (userCoord.Contains("b") || userCoord.Contains("B"))
        {
            if (userCoord.Contains("1"))
            {
                b1 = "O";
                picked = true;
            }
            if (userCoord.Contains("2"))
            {
                b2 = "O";
                picked = true;
            }
            if (userCoord.Contains("3"))
            {
                b3 = "O";
                picked = true;
            }
            else if (picked == false)
            {
                Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
                Thread.Sleep(1500);
                printGrid();
            }
        }
        if (userCoord.Contains("c") || userCoord.Contains("C"))
        {
            if (userCoord.Contains("1"))
            {
                c1 = "O";
                picked = true;
            }
            if (userCoord.Contains("2"))
            {
                c2 = "O";
                picked = true;
            }
            if (userCoord.Contains("3"))
            {
                c3 = "O";
                picked = true;
            }
            else if (picked == false)
            {
                Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
                Thread.Sleep(1500);
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
    spacesOccupied++;
    winLoseDraw();
    printGrid();
}

void winLoseDraw()
{
    if (player == 1)
    {
        xOrO = "X";
    }
    else if (player == 2)
    {
        xOrO = "O";
    }
    Console.WriteLine(xOrO);
    //player wins
    //horizontal
    if (a1.Contains(xOrO) && a2.Contains(xOrO) && a3.Contains(xOrO)) { playerWins(); }//toprow
    if (b1.Contains(xOrO) && b2.Contains(xOrO) && b3.Contains(xOrO)) { playerWins(); }//middlerow
    if (c1.Contains(xOrO) && c2.Contains(xOrO) && c3.Contains(xOrO)) { playerWins(); }//bottom
    //vertical
    if (a1.Contains(xOrO) && b1.Contains(xOrO) && c1.Contains(xOrO)) { playerWins(); }//left
    if (a2.Contains(xOrO) && b2.Contains(xOrO) && c2.Contains(xOrO)) { playerWins(); }//middle
    if (a3.Contains(xOrO) && b3.Contains(xOrO) && c3.Contains(xOrO)) { playerWins(); }//right
    //diagonal
    if (a1.Contains(xOrO) && b2.Contains(xOrO) && c3.Contains(xOrO)) { playerWins(); }//lr
    if (a3.Contains(xOrO) && b2.Contains(xOrO) && c1.Contains(xOrO)) { playerWins(); }//rl

    //draw
    if (spacesOccupied == 9)
    {
        Console.WriteLine("It's a draw!");
        Thread.Sleep(1500);
        newGame();
    }
    void playerWins()
    {
        Console.WriteLine("You win!");
        Thread.Sleep(1500);
        newGame();
    }
}