using VirtualPetCSharp;

namespace MyGameCompany.VirtualPetCSharp;

internal class Human
{
    public string Name { get; set; }
    private int _score;
    private int _scoreBonuses;
    private int _scoreDeductions;

    internal Human(string name)
    {
        Name = name;
        _score = 0;
    }
    internal void treatPet(Pet thePet)
    {
        Console.WriteLine("You give your pet a treat!");
        thePet.setHappiness(25);
        thePet.setHunger(-10);
        thePet.setHealth(-10);
        thePet.setHaveToGo(25);
        Console.WriteLine("Happiness increase by 25 points.");
        Console.WriteLine("Hunger decreased by 10 points.");
        Console.WriteLine("Health decreased by 10 points.");
    }
    internal Pet adoptAPet()
    {
        displayMenu();
        char petType;
        petType = Console.ReadLine()[0];
        petType = Char.ToUpper(petType);
        while (petType != 'D' && petType != 'C' && petType != 'T' && petType != 'A')
        {
            Console.WriteLine("That is not a valid choice.");
            displayMenu();
            petType = Console.ReadLine()[0];
            petType = Char.ToUpper(petType);
        }

        Console.WriteLine("Give your pet a name.");
        string name = Console.ReadLine();
        switch (petType)
        {
            case 'D':
                {
                    Pet pet = new Dog(name);
                    MakeSound(pet);
                    return pet;

                }
                break;
            case 'C':
                {
                    Pet pet = new Cat(name);
                    MakeSound(pet);
                    return pet;
                }
                break;
            case 'T':
                {
                    Pet pet = new Rex(name);
                    MakeSound(pet);
                    return pet;
                }
                break;
            case 'A':
                {
                    Pet pet = new Alien(name);
                    MakeSound(pet);
                    return pet;
                }
                break;
        }
        return new Pet("");
    }
    internal void feedPet(Pet thePet) => thePet.eat();

    internal void letPetSleep(Pet thePet) => thePet.sleep();
    internal void playWithPet(Pet thePet) => thePet.play();

    internal void scoldPet(Pet thePet)
    {
        Console.WriteLine("You yell at your pet and call it nasty names.");
        thePet.setHappiness(-25);
        Console.WriteLine("Happiness decreased by 25.");
    }
    internal void takeForAWalk(Pet thePet)
    {
        Console.WriteLine("You let your pet do it's \"business\".");
        thePet.setHaveToGo(-100);
        Console.WriteLine("Your pet won't have to go out for a while.");
    }
    internal void calcluateScore(Pet thePet)
    {
        int fatigue = thePet.getFatigue();
        int happiness = thePet.getHappiness();
        int haveToGo = thePet.getHaveToGo();
        int health = thePet.getHealth();
        int hunger = thePet.getHunger();

        int fatigueScore = 100 - fatigue;
        int happinessScore = happiness;
        int haveToGoScore = (100 - haveToGo);
        int healthScore = health;
        int hungerScore = 100 - hunger;

        Console.WriteLine($"Fatigue score: {fatigueScore}");
        Console.WriteLine($"Happiness score: {happinessScore}");
        Console.WriteLine($"Need to go to the \"bathroom\" score: {haveToGoScore}");
        Console.WriteLine($"Health score: {healthScore}");
        Console.WriteLine($"Hunger score: {hungerScore}");
        Console.WriteLine($"Bonuses: {_scoreBonuses}");
        Console.WriteLine($"Dedudctions: {_scoreDeductions}");
        _score = fatigueScore + happinessScore + haveToGoScore + healthScore + hungerScore;
        _score += _scoreBonuses;
        _score -= _scoreDeductions;

        Console.WriteLine($"Your final score is {_score}");
    }
    internal void setScoreBonuses(int bonus)
    {
        if (bonus != 100)
            Console.WriteLine("Invalid bonus.");
        else
            _scoreBonuses += bonus;
    }
    internal void setScoreDeduction(int deduction)
    {
        if (deduction != 100)
            Console.WriteLine("Invalid deduction.");
        else
            _scoreDeductions += deduction;
    }
    void displayMenu()
    {
        Console.WriteLine("Select which type of pet you would like to have.");
        Console.WriteLine("(D)og:");
        Console.WriteLine("\t Dogs are happy creatures, easy to please. However, they are often ");
        Console.WriteLine("hungry and will bite you if you don't feed them!");
        Console.WriteLine();
        Console.WriteLine("(C)at:");
        Console.WriteLine("\t Cats are picky eaters and hard to please. They have better health ");
        Console.WriteLine("due to their nine lives.");
        Console.WriteLine();
        Console.WriteLine("(T)yrannosaurus Rex:");
        Console.WriteLine("\t The Tyrannosaurus Rex is always hungry. It does not have very good ");
        Console.WriteLine("health considering the fact that it became extinct millions of years ago.");
        Console.WriteLine();
        Console.WriteLine("(A)lien:");
        Console.WriteLine("\t Aliens are tired from their long intergalatic voyage and really need ");
        Console.WriteLine("to go to the bathroom. Due to their Star Trek-like medical technology, ");
        Console.WriteLine("they have better health.");
    }

    private void MakeSound(Pet pet)
    {
        Console.Write($"{pet.getName()}  says hi: ");
        pet.makeSound();
        Console.WriteLine();
    }
}