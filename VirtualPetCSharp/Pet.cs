namespace MyGameCompany.VirtualPetCSharp;

internal class Pet
{
    protected string _name;
    protected int _fatigue;
    protected int _happiness;
    protected int _haveToGo;
    protected int _health;
    protected int _hunger;


    internal Pet(string name)
    {
        _name = name;
    }

    internal virtual void attack() { }

    internal virtual void displayHappiness() { }

    internal virtual void eat() { }

    internal virtual void sleep() { }
    internal virtual void play() { }

    internal virtual void makeSound() { }

    internal int getFatigue()
    {
        return _fatigue;
    }
    internal int getHappiness()
    {
        return _happiness;
    }
    internal int getHaveToGo()
    {
        return _haveToGo;
    }
    internal int getHealth()
    {
        return _health;
    }
    internal int getHunger()
    {
        return _hunger;
    }
    internal void setFatigue(int fatigue)
    {
        _fatigue += fatigue;
        if (_fatigue < 0)
        {
            _fatigue = 0;
        }
        else if (_fatigue > 100)
        {
            _fatigue = 100;
        }
    }
    internal void setHappiness(int happiness)
    {
        _happiness += happiness;
        if (_happiness < 0)
        {
            _happiness = 0;
        }
        else if (_happiness > 100)
        {
            _happiness = 100;
        }

    }
    internal void setHaveToGo(int haveToGo)
    {
        _haveToGo += haveToGo;
        if (_haveToGo > 100)
        {
            _haveToGo = 100;
        }
        else if (_haveToGo < 0)
        {
            _haveToGo = 0;
        }

    }
    internal void setHealth(int health)
    {
        _health += health;

        if (_health < 0)
        {
            _health = 0;
        }
        else if (_health > 100)
        {
            _health = 100;
        }
    }
    internal void setHunger(int hunger)
    {
        _hunger += hunger;

        if (_hunger < 0)
        {
            _hunger = 0;
        }
        else if (_hunger > 100)
        {
            _hunger = 100;
        }
    }
    internal string getName()
    {
        return _name;
    }

    internal void displayStatus()
    {
        Console.WriteLine($"All Values Range from 0 to 100;");
        Console.WriteLine($"Fatigue: {_fatigue}");
        Console.WriteLine($"Happiness: {_happiness}");
        Console.WriteLine($"Need to go to the \"bathroom\": {_haveToGo}");
        Console.WriteLine($"Health: {_health}");
        Console.WriteLine($"Hunger: {_hunger}");
        Console.WriteLine();
    }
}