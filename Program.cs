//main
int userChoice = GetUserChoice();
while(userChoice != 3)
{
    MenuSelection(userChoice);
    userChoice = GetUserChoice();
}


//methods
static int GetUserChoice()
{
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice))
    {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu()
{
    Console.Clear();
    System.Console.WriteLine("1) Full triangle\n2) Partial triangle\n3) Exit");
}

static bool IsValidChoice(string userInput)
{
    if(userInput == "1" || userInput == "2" || userInput == "3")
    {
        return true;
    }
    else return false;
}

static void MenuSelection(int menuChoice)
{
    if(menuChoice == 1)
    {
        GetFull();
    }
    else if(menuChoice == 2)
    {
        GetPartial();
    }
    else if(menuChoice != 3)
    {
        Invalid();
    }
}

static void GetFull()
{
    Space();
    Random rnd = new Random();
    int num = rnd.Next(3, 10);

    for(int i = 1; i <= num; i++)
    {
        for(int j = 1; j <= i; j++)
        {
            System.Console.Write("o");
        }
        System.Console.WriteLine();
    }
    Space();
    PauseAction();
}

static void GetPartial()
{
    Space();
    Random rnd = new Random();
    int num = rnd.Next(3, 10);

    Random rand = new Random();
    int number;
    for(int i = 1; i <= num; i++)
    {
        for(int j = 1; j <= i; j++)
        {
            number = rand.Next(2);
            if(number == 0)
            {
                System.Console.Write("o");
            }
            else if(number == 1)
            {
                System.Console.Write(" ");
            }
        }
        System.Console.WriteLine();
    }
    Space();
    PauseAction();
}

static void Invalid()
{
    Space();
    System.Console.WriteLine("Invalid selection");
    PauseAction();
}

static void PauseAction()
{
    System.Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}

static void Space()
{
    System.Console.WriteLine();
}