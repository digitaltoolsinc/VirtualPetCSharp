using MyGameCompany.VirtualPetCSharp;

namespace VirtualPetCSharp
{
    internal class Dog : Pet
    {

        internal Dog(string name) : base(name)
        {
            _happiness = 75;
            _fatigue = 25;
            _hunger = 75;
            _haveToGo = 75;
            _health = 50;

        }
        internal override void attack()
        {
            Console.WriteLine($"{base.getName()} bites you! Your dog is angry!");
        }
        internal override void displayHappiness()
        {
            Console.WriteLine($"{base.getName()} wags its tail! Your dog is happy!");
        }
        internal override void eat()
        {
            Console.WriteLine($"{base.getName()} gobbles up its food! Yum!");
            setHunger(-25);
            setHappiness(25);
            setHaveToGo(25);
            Console.WriteLine("Hunger is decreased by 25 points.");
            Console.WriteLine("Happiness is increased by 25 points.");
            Console.WriteLine("Your dog's need for a walk has increase by 25 points.");
        }
        internal override void play()
        {
            Console.WriteLine("You and your dog play fetch!");
            setHunger(25);
            setHappiness(25);
            setHealth(25);
            setFatigue(25);
            Console.WriteLine("Hunger is increased by 25 points.");
            Console.WriteLine("Happiness is increased by 25 points.");
            Console.WriteLine("Health is increased by 25 points.");
            Console.WriteLine("Your dog fatigue has increased by 25 points.");
        }
        internal override void sleep()
        {
            Console.WriteLine("ZZZZZZZZZZZZ (Dreams of biscuits and long walks in the park)");
            setHunger(25);
            setHappiness(25);
            setFatigue(-100);
            setHaveToGo(50);
            Console.WriteLine("Hunger is increased by 25 points.");
            Console.WriteLine("Happiness is increased by 25  points.");
            Console.WriteLine("Fatigue is decreased by 100 points.");
            Console.WriteLine("Your dog's need to go has increased by 50 points.");
        }
        internal override void makeSound()
        {
            var random = new Random();
            int randomNumber = random.Next(0, 2);
            if (randomNumber < 1)
                Console.WriteLine("Ruff! Ruff!");
            else
                Console.WriteLine("Arf! Arf!");

        }
    }
}
