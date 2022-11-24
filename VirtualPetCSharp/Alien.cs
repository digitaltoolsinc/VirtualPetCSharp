using MyGameCompany.VirtualPetCSharp;

namespace VirtualPetCSharp
{
    internal class Alien : Pet
    {


        internal Alien(string name) : base(name)
        {
            _happiness = 25;
            _fatigue = 75;
            _hunger = 25;
            _haveToGo = 75;
            _health = 75;

        }
        internal override void attack()
        {
            Console.WriteLine("Your alien vaporizes a car! It is angry!");
        }
        internal override void displayHappiness()
        {
            Console.WriteLine("Your alien could beam up to heaven. It is happy!");
        }
        internal override void eat()
        {
            Console.WriteLine("Your alien replicates a burrito. Way better than Taco Bell.");
            setHunger(-50);
            setHappiness(25);
            setHaveToGo(25);
            Console.WriteLine("Hunger is decreased by 50 points.");
            Console.WriteLine("Happiness is increased by 25 points.");
            Console.WriteLine("Your alien's need to go has increase by 25 points.");
        }

        internal override void play()
        {
            Console.WriteLine("You and your alien slingshot around the moon in a spaceship!");
            setHunger(50);
            setHappiness(75);
            setHealth(25);
            setFatigue(75);
            Console.WriteLine("Hunger is increased by 50 points.");
            Console.WriteLine("Happiness is increased by 75 points.");
            Console.WriteLine("Health is increased by 25 points.");
            Console.WriteLine("Your alien's fatigue has increased by 75 points.");
        }
        internal override void sleep()
        {
            Console.WriteLine("ZZZZZZZZZZZZ (Dreams of hyperspace)");
            setHunger(50);
            setHappiness(50);
            setFatigue(-100);
            setHaveToGo(50);
            Console.WriteLine("Hunger is increased by 50 points.");
            Console.WriteLine("Happiness is increased by 50  points.");
            Console.WriteLine("Fatigue is decreased by 100 points.");
            Console.WriteLine("Your alien's need to go has increased by 50 points.");
        }
        internal override void makeSound()
        {
            Console.WriteLine("Ork, Eek, Onk!");
        }
    }
}
