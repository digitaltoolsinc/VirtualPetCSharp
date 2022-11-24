using MyGameCompany.VirtualPetCSharp;

namespace VirtualPetCSharp
{
    internal class Cat : Pet
    {
        internal Cat(string name) : base(name)
        {
            _happiness = 50;
            _fatigue = 50;
            _hunger = 25;
            _haveToGo = 50;
            _health = 75;

        }
        internal override void attack()
        {
            Console.WriteLine("Your cat claws at you. It is angry!");
        }
        internal override void displayHappiness()
        {
            Console.WriteLine("Purrrrrrr!");
        }
        internal override void eat()
        {
            Console.WriteLine("Your cat nibbles it's food.");
            setHunger(-10);
            setHappiness(15);
            setHaveToGo(25);
            Console.WriteLine("Hunger is decreased by 10 points.");
            Console.WriteLine("Happiness is increased by 15 points.");
            Console.WriteLine("Your cat's need for the litter box has increase by 25 points.");
        }

        internal override void play()
        {
            Console.WriteLine("You give your cat a mouse and a ball of yarn to play with. Yay!");
            setHunger(15);
            setHappiness(15);
            setHealth(25);
            setFatigue(50);
            Console.WriteLine("Hunger is increased by 15 points.");
            Console.WriteLine("Happiness is increased by 15  points.");
            Console.WriteLine("Health is increased by 25 points.");
            Console.WriteLine("Your cat's fatigue has increased by 50 points.");
        }
        internal override void sleep()
        {
            Console.WriteLine("ZZZZZZZZZZZZ (Dreams of tunafish and mice)");
            setHunger(15);
            setHappiness(50);
            setFatigue(-100);
            setHaveToGo(50);
            Console.WriteLine("Hunger is increased by 15 points.");
            Console.WriteLine("Happiness is increased by 50  points.");
            Console.WriteLine("Fatigue is decreased by 100 points.");
            Console.WriteLine("Your cat's need to go has increased by 50 points.");
        }
        internal override void makeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
