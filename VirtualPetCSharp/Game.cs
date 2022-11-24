namespace MyGameCompany.VirtualPetCSharp;
internal class Game
{

    void instructions()
    {
        Console.WriteLine("Welcome to the Virtual Pets game!");
        Console.WriteLine("In this game you will choose a type of pet and do things with it that wiil ");
        Console.WriteLine("determine its fatigue, its happiness, its need to go to the \"bathroom\", ");
        Console.WriteLine("its hunger, and its health. You will be scored on how well you handle these.");
        Console.WriteLine("If one of the values gets too bad, you will be deducted points. If you do a ");
        Console.WriteLine(" really good job, you will earn more points! Good luck!");
        Console.WriteLine();
    }
    internal void playGame()
    {
        instructions();
        Console.Write("What is your name?");
        string name = Console.ReadLine();
        Human theHuman = new Human(name);
        Console.Write($"Hi there {theHuman.Name}!");
        Console.WriteLine();

        Pet thePet = theHuman.adoptAPet();

        char choice;
        do
        {
            thePet.displayStatus();

            if (thePet.getFatigue() == 100 || thePet.getHappiness() == 0 || thePet.getHaveToGo() == 100 || thePet.getHealth() == 0 || thePet.getHunger() == 100)
            {
                thePet.attack();
                theHuman.setScoreDeduction(100);
                Console.Write("Your final score is decreased by 100 points.");
            }
            else if (thePet.getHappiness() == 100 && !(thePet.getFatigue() == 100 || thePet.getHaveToGo() == 100 || thePet.getHealth() == 0 || thePet.getHunger() == 100))
            {
                thePet.displayHappiness();
                theHuman.setScoreBonuses(100);
                Console.Write("Your final score is increased by 100 points.");
            }
            displayMenu();
            choice = Console.ReadLine()[0];
            switch (choice)
            {
                case '1':
                    theHuman.playWithPet(thePet);
                    break;
                case '2':
                    theHuman.feedPet(thePet);
                    break;
                case '3':
                    theHuman.treatPet(thePet);
                    break;
                case '4':
                    theHuman.scoldPet(thePet);
                    break;
                case '5':
                    theHuman.takeForAWalk(thePet);
                    break;
                case '6':
                    theHuman.letPetSleep(thePet);
                    break;
                case '7':
                    exit(ref theHuman, thePet);
                    break;
                default:
                    Console.Write("That is not a valid choice.");
                    break;
            }
        } while (choice != '7');
    }
    void displayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1. Play with your pet.");
        Console.WriteLine("2. Feed your pet.");
        Console.WriteLine("3. Treat your pet.");
        Console.WriteLine("4. Scold your pet.");
        Console.WriteLine("5. Take your pet to the \"bathroom\".");
        Console.WriteLine("6. Let your pet sleep.");
        Console.WriteLine("7. Exit.");
    }



    void exit(ref Human theHuman, Pet thePet)
    {
        theHuman.calcluateScore(thePet);
        Console.Write($"Thank you for playing the Virtual Pets Game! Goodbye {theHuman.Name}!");
    }
}