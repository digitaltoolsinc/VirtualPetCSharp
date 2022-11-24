using MyGameCompany.VirtualPetCSharp;

namespace VirtualPetCSharp
{
    internal class Rex : Pet
    {


        internal Rex(string name) : base(name)
        {
            _happiness = 25;
            _fatigue = 50;
            _hunger = 90;
            _haveToGo = 50;
            _health = 25;

        }
        internal override void attack()
        {
            Console.WriteLine("Your Tyrannosaurus Rex takes a big chomp out of a house. It is angry!");
        }
        internal override void displayHappiness()
        {
            Console.WriteLine("Your Tyrannosaurus Rex wags its tail. It is happy!");
        }
        internal override void eat()
        {
            Console.WriteLine("Your Tyrannosaurus Rex eats a bear. Despite the fur, it's delicious!");
            setHunger(-5);
            setHappiness(25);
            setHaveToGo(25);
            Console.WriteLine("Hunger is decreased by 5 points.");
            Console.WriteLine("Happiness is increased by 25 points.");
            Console.WriteLine("Your Tyrannosaurus Rex's need to go has increase by 25 points.");
        }

        internal override void play()
        {
            Console.WriteLine("You and your Tyrannosaurus Rex eat popcorn and watch Jurrasic Park.");
            setHunger(50);
            setHappiness(25);
            setHealth(25);
            setFatigue(50);
            Console.WriteLine("Hunger is increased by 50 points.");
            Console.WriteLine("Happiness is increased by 25  points.");
            Console.WriteLine("Health is increased by 25 points.");
            Console.WriteLine("Your Tyrannosaurus Rex's fatigue has increased by 50 points.");
        }
        internal override void sleep()
        {
            Console.WriteLine("ZZZZZZZZZZZZ (Dreams of killing and eating)");
            setHunger(75);
            setHappiness(50);
            setFatigue(-100);
            setHaveToGo(50);
            Console.WriteLine("Hunger is increased by 75 points.");
            Console.WriteLine("Happiness is increased by 50  points.");
            Console.WriteLine("Fatigue is decreased by 100 points.");
            Console.WriteLine("Your Tyrannosaurus Rex's need to go has increased by 50 points.");
        }
        internal override void makeSound()
        {
            Console.WriteLine("Roar!");
        }
    }
}
