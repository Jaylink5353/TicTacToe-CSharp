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
string CPUchar = "N";
bool CPUPlayed = false;


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
    charDetermine();
}

void charDetermine()
{
    if (player == 1)
    {
        xOrO = "X";
    }
    else if (player == 2)
    {
        xOrO = "O";
    }

    if (player == 1)
    {
        CPUchar = "O";
    }
    if (player == 2)
    {
        CPUchar = "X";
    }
    Console.WriteLine($"You are {xOrO}.");
    Thread.Sleep(1000);
}


//main loop
Console.WriteLine(help);
while (play == true)
{
    //player = 1;
    charDetermine();
    printGrid(false);

}


void printGrid(bool cpuWin)
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
    if (cpuWin == false)
    {
        Console.WriteLine("Type a coordinate!");
        userInput();
        CPUPlayed = false; 
    }

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
        printGrid(false);

    }
    if (userCoord == "h")
    {
        Console.WriteLine($"{help} Press any key to continue.");
        Console.ReadKey();
        printGrid(false);
    }
    Console.WriteLine($"You've selected {userCoord}");
    Thread.Sleep(500);
    fillGrid();
    

}

void fillGrid()
{
    void spaceFull()
    {
        Console.WriteLine("Looks like that space is taken. Choose another one!");
        Thread.Sleep(1500);
        printGrid(false);
    }
    picked = false;
    if (player == 1)
    {
        if (userCoord.Contains("a") || userCoord.Contains("A"))
        {
            if (userCoord.Contains("1"))
            {
                if (a1 != "-"){ spaceFull(); }
                a1 = "X";
                picked = true;
            }
            if (userCoord.Contains("2"))
            {
                if (a2 != "-"){ spaceFull(); }
                a2 = "X";
                picked = true;
            }
            if (userCoord.Contains("3"))
            {
                if (a3 != "-"){ spaceFull(); }
                a3 = "X";
                picked = true;
            }
            else if (picked == false)
            {
                Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
                Thread.Sleep(1500);
                printGrid(false);
            }
        }
        if (userCoord.Contains("b") || userCoord.Contains("B"))
        {
            if (userCoord.Contains("1"))
            {
                if (b1 != "-"){ spaceFull(); }
                b1 = "X";
                picked = true;
            }
            if (userCoord.Contains("2"))
            {
                if (b2 != "-"){ spaceFull(); }
                b2 = "X";
                picked = true;
            }
            if (userCoord.Contains("3"))
            {
                if (b3 != "-"){ spaceFull(); }
                b3 = "X";
                picked = true;
            }
            else if (picked == false)
            {
                Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
                Thread.Sleep(1500);
                printGrid(false);
            }
        }
        if (userCoord.Contains("c") || userCoord.Contains("C"))
        {
            if (userCoord.Contains("1"))
            {
                if (c1 != "-"){ spaceFull(); }
                c1 = "X";
                picked = true;
            }
            if (userCoord.Contains("2"))
            {
                if (c2 != "-"){ spaceFull(); }
                c2 = "X";
                picked = true;
            }
            if (userCoord.Contains("3"))
            {
                if (c3 != "-"){ spaceFull(); }
                c3 = "X";
                picked = true;
            }
            else if (picked == false)
            {
                Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
                Thread.Sleep(1500);
                printGrid(false);
            }
        }
        else if (picked == false)
        {
            Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
            Thread.Sleep(500);
            printGrid(false);
        }
    }
    else if (player == 2)
    {
        if (userCoord.Contains("a") || userCoord.Contains("A"))
        {
            if (userCoord.Contains("1"))
            {
                if (a1 != "-"){ spaceFull(); }
                a1 = "O";
                picked = true;
            }
            if (userCoord.Contains("2"))
            {
                if (a2 != "-"){ spaceFull(); }
                a2 = "O";
                picked = true;
            }
            if (userCoord.Contains("3"))
            {
                if (a3 != "-"){ spaceFull(); }
                a3 = "O";
                picked = true;
            }
            else if (picked == false)
            {
                Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
                Thread.Sleep(1500);
                printGrid(false);
            }
        }
        if (userCoord.Contains("b") || userCoord.Contains("B"))
        {
            if (userCoord.Contains("1"))
            {
                if (b1 != "-"){ spaceFull(); }
                b1 = "O";
                picked = true;
            }
            if (userCoord.Contains("2"))
            {
                if (b2 != "-"){ spaceFull(); }
                b2 = "O";
                picked = true;
            }
            if (userCoord.Contains("3"))
            {
                if (b3 != "-"){ spaceFull(); }
                b3 = "O";
                picked = true;
            }
            else if (picked == false)
            {
                Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
                Thread.Sleep(1500);
                printGrid(false);
            }
        }
        if (userCoord.Contains("c") || userCoord.Contains("C"))
        {
            if (userCoord.Contains("1"))
            {
                if (c1 != "-"){ spaceFull(); }
                c1 = "O";
                picked = true;
            }
            if (userCoord.Contains("2"))
            {
                if (c2 != "-"){ spaceFull(); }
                c2 = "O";
                picked = true;
            }
            if (userCoord.Contains("3"))
            {
                if (c3 != "-"){ spaceFull(); }
                c3 = "O";
                picked = true;
            }
            else if (picked == false)
            {
                Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
                Thread.Sleep(1500);
                printGrid(false);
            }
        }
        else if (picked == false)
        {
            Console.WriteLine("Hmm. I don't know what coordinate that is. Try again!");
            Thread.Sleep(500);
            printGrid(false);
        }
    }
    spacesOccupied++;
    cpuThink();
    winLoseDraw();
    printGrid(false);
}

void winLoseDraw()
{
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

    //CPU Wins
    if (a1.Contains(CPUchar) && a2.Contains(CPUchar) && a3.Contains(CPUchar)) { CPUWins(); }//toprow
    if (b1.Contains(CPUchar) && b2.Contains(CPUchar) && b3.Contains(CPUchar)) { CPUWins(); }//middlerow
    if (c1.Contains(CPUchar) && c2.Contains(CPUchar) && c3.Contains(CPUchar)) { CPUWins(); }//bottom
    //vertical
    if (a1.Contains(CPUchar) && b1.Contains(CPUchar) && c1.Contains(CPUchar)) { CPUWins(); }//left
    if (a2.Contains(CPUchar) && b2.Contains(CPUchar) && c2.Contains(CPUchar)) { CPUWins(); }//middle
    if (a3.Contains(CPUchar) && b3.Contains(CPUchar) && c3.Contains(CPUchar)) { CPUWins(); }//right
    //diagonal
    if (a1.Contains(CPUchar) && b2.Contains(CPUchar) && c3.Contains(CPUchar)) { CPUWins(); }//lr
    if (a3.Contains(CPUchar) && b2.Contains(CPUchar) && c1.Contains(CPUchar)) { CPUWins(); }//rl
    //draw
    if (spacesOccupied >= 9)
    {
        printGrid(true);
        Console.WriteLine("It's a draw!");
        Thread.Sleep(2000);
        newGame();
    }
    void playerWins()
    {
        printGrid(true);
        Console.WriteLine("You win!");
        Thread.Sleep(2000);
        newGame();
    }
    void CPUWins()
    {
        printGrid(true);
        Console.WriteLine("I win! Better luck next time!");
        Thread.Sleep(2000);
        newGame();
    }
}

void cpuThink()
{
    Console.WriteLine("I'm Thinking....");
    Thread.Sleep(2000);
    //See if CPU Can make winning move
     if (a1 == CPUchar && a2 == CPUchar && a3 == "-" && CPUPlayed == false) { a3 = CPUchar; CPUPlayed = true; }
    if (a1 == CPUchar && a3 == CPUchar && a2 == "-" && CPUPlayed == false) { a2 = CPUchar;  CPUPlayed = true; }
    if (a2 == CPUchar && a3 == CPUchar && a1 == "-" && CPUPlayed == false) { a1 = CPUchar;  CPUPlayed = true; }
    //middle row
    if (b1 == CPUchar && b2 == CPUchar && b3 == "-" && CPUPlayed == false) { b3 = CPUchar; CPUPlayed = true; }
    if (b1 == CPUchar && b3 == CPUchar && b2 == "-" && CPUPlayed == false) { b2 = CPUchar; CPUPlayed = true; }
    if (b2 == CPUchar && b3 == CPUchar && b1 == "-" && CPUPlayed == false) { b1 = CPUchar;  CPUPlayed = true; }
    //Bottom Row
    if (c1 == CPUchar && c2 == CPUchar && c3 == "-" && CPUPlayed == false) { c3 = CPUchar; CPUPlayed = true; }
    if (c1 == CPUchar && c3 == CPUchar && c2 == "-" && CPUPlayed == false) { c2 = CPUchar; CPUPlayed = true; }
    if (c2 ==  CPUchar && c3 == CPUchar && c1 == "-" && CPUPlayed == false) { c1 = CPUchar;  CPUPlayed = true; }
    //Left Colum
    if (a1 == CPUchar && b1 ==  CPUchar && c1 == "-" && CPUPlayed == false) { c1 = CPUchar;  CPUPlayed = true; }
    if (a1 == CPUchar && c1 == CPUchar && b1 == "-" && CPUPlayed == false) { b1 = CPUchar; CPUPlayed = true; }
    if (b1 == CPUchar && c1 == CPUchar && a1 == "-" && CPUPlayed == false) { a1 = CPUchar;  CPUPlayed = true; }
    //Middle Colum
    if (a2 == CPUchar && b2 ==  CPUchar && c2 == "-" && CPUPlayed == false) { c2 = CPUchar; CPUPlayed = true; }
    if (a2 == CPUchar && c2 ==  CPUchar && b2 == "-" && CPUPlayed == false) { b2 = CPUchar; CPUPlayed = true; }
    if (b2 == CPUchar && c2 ==  CPUchar && a2 == "-" && CPUPlayed == false) { a2 = CPUchar; CPUPlayed = true; }
    //Bottom Colum
    if (a3 == CPUchar && b3 ==  CPUchar && c2 == "-" && CPUPlayed == false) { c3 = CPUchar; CPUPlayed = true; }
    if (a3 == CPUchar && c3 ==  CPUchar && b3 == "-" && CPUPlayed == false) { b3 = CPUchar; CPUPlayed = true; }
    if (b3 == CPUchar && c3 ==  CPUchar && a3 == "-" && CPUPlayed == false) { a3 = CPUchar; CPUPlayed = true; }
    //Left Diagonal
    if (a1 == CPUchar && b2 == CPUchar && c3 == "-" && CPUPlayed == false) { c3 = CPUchar; CPUPlayed = false; }
    if (a1 == CPUchar && c3 == CPUchar && b2 == "-" && CPUPlayed == false) { b2 = CPUchar; CPUPlayed = false; }
    if (b2 == CPUchar && c3 == CPUchar && a1 == "-" && CPUPlayed == false) { a1 = CPUchar; CPUPlayed = false; }
    //Right DIagomnal
    if (a3 == CPUchar && b2 ==  CPUchar && c1 == "-" && CPUPlayed == false) { c1 = CPUchar; CPUPlayed = true; }
    if (a3 == CPUchar && c1 ==  CPUchar && b2 == "-" && CPUPlayed == false) { b2 = CPUchar; CPUPlayed = true; }
    if (b2 == CPUchar && c1 ==  CPUchar && a3 == "-" && CPUPlayed == false) { a3 = CPUchar; CPUPlayed = true; }

    //Block Player
    //Top Row
    if (a1 == xOrO && a2 == xOrO && a3 == "-" && CPUPlayed == false) { a3 = CPUchar; CPUPlayed = true; }
    if (a1 == xOrO && a3 == xOrO && a2 == "-" && CPUPlayed == false) { a2 = CPUchar;  CPUPlayed = true; }
    if (a2 == xOrO && a3 == xOrO && a1 == "-" && CPUPlayed == false) { a1 = CPUchar;  CPUPlayed = true; }
    //middle row
    if (b1 == xOrO && b2 == xOrO && b3 == "-" && CPUPlayed == false) { b3 = CPUchar; CPUPlayed = true; }
    if (b1 == xOrO && b3 == xOrO && b2 == "-" && CPUPlayed == false) { b2 = CPUchar; CPUPlayed = true; }
    if (b2 == xOrO && b3 == xOrO && b1 == "-" && CPUPlayed == false) { b1 = CPUchar;  CPUPlayed = true; }
    //Bottom Row
    if (c1 == xOrO && c2 == xOrO && c3 == "-" && CPUPlayed == false) { c3 = CPUchar; CPUPlayed = true; }
    if (c1 == xOrO && c3 == xOrO && c2 == "-" && CPUPlayed == false) { c2 = CPUchar; CPUPlayed = true; }
    if (c2 ==  xOrO && c3 == xOrO && c1 == "-" && CPUPlayed == false) { c1 = CPUchar;  CPUPlayed = true; }
    //Left Colum
    if (a1 == xOrO && b1 ==  xOrO && c1 == "-" && CPUPlayed == false) { c1 = CPUchar;  CPUPlayed = true; }
    if (a1 == xOrO && c1 == xOrO && b1 == "-" && CPUPlayed == false) { b1 = CPUchar; CPUPlayed = true; }
    if (b1 == xOrO && c1 == xOrO && a1 == "-" && CPUPlayed == false) { a1 = CPUchar;  CPUPlayed = true; }
    //Middle Colum
    if (a2 == xOrO && b2 ==  xOrO && c2 == "-" && CPUPlayed == false) { c2 = CPUchar; CPUPlayed = true; }
    if (a2 == xOrO && c2 ==  xOrO && b2 == "-" && CPUPlayed == false) { b2 = CPUchar; CPUPlayed = true; }
    if (b2 == xOrO && c2 ==  xOrO && a2 == "-" && CPUPlayed == false) { a2 = CPUchar; CPUPlayed = true; }
    //Bottom Colum
    if (a3 == xOrO && b3 ==  xOrO && c2 == "-" && CPUPlayed == false) { c3 = CPUchar; CPUPlayed = true; }
    if (a3 == xOrO && c3 ==  xOrO && b3 == "-" && CPUPlayed == false) { b3 = CPUchar; CPUPlayed = true; }
    if (b3 == xOrO && c3 ==  xOrO && a3 == "-" && CPUPlayed == false) { a3 = CPUchar; CPUPlayed = true; }
    //Left Diagonal
    if (a1 == xOrO && b2 == xOrO && c3 == "-" && CPUPlayed == false) { c3 = CPUchar; CPUPlayed = false; }
    if (a1 == xOrO && c3 == xOrO && b2 == "-" && CPUPlayed == false) { b2 = CPUchar; CPUPlayed = false; }
    if (b2 == xOrO && c3 == xOrO && a1 == "-" && CPUPlayed == false) { a1 = CPUchar; CPUPlayed = false; }
    //Right DIagomnal
    if (a3 == xOrO && b2 ==  xOrO && c1 == "-" && CPUPlayed == false) { c1 = CPUchar; CPUPlayed = true; }
    if (a3 == xOrO && c1 ==  xOrO && b2 == "-" && CPUPlayed == false) { b2 = CPUchar; CPUPlayed = true; }
    if (b2 == xOrO && c1 ==  xOrO && a3 == "-" && CPUPlayed == false) { a3 = CPUchar; CPUPlayed = true; }

    //Play Middle!
    if (b2 == "-" && CPUPlayed == false) { b2 = CPUchar; CPUPlayed = true; }
    //Check if Corners are Occupied
    if (a1 == "-" && CPUPlayed == false) { a1 = CPUchar; CPUPlayed = true; }
    if (c3 == "-" && CPUPlayed == false) { c3 = CPUchar; CPUPlayed = true; }
    if (c1 == "-" && CPUPlayed == false) { c1 = CPUchar; CPUPlayed = true; }
    if (a3 == "-" && CPUPlayed == false) { a3 = CPUchar; CPUPlayed = true; }

    //MUST BE AT END OF FUNCTION
    spacesOccupied++;
    CPUPlayed = false;

}

