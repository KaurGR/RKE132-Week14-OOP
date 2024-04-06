using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Name your dog:");
        string myDogName = Console.ReadLine();
        Dog myDog = new Dog(myDogName);

        Dog neighboursDog = new Dog("Good Boy");
        Console.WriteLine($"My dog's name is {myDog.Name}.");
        Console.WriteLine($"My neighbour's dog name is {neighboursDog.Name}.");

        Console.WriteLine("Rename your dog:");
        myDog.Rename(Console.ReadLine());
        Console.WriteLine($"Level of happiness: {myDog.LevelOfHappiness}");

        myDog.Bark();
        Console.WriteLine($"Level of happiness: {myDog.LevelOfHappiness}");

        while (myDog.LevelOfHappiness != 5)
        {
            myDog.Bark();
        }

        myDog.TailWag();
    }
}

class Dog
{
    private string _name;
    private int _levelOfHappiness;

    public Dog(string name)
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Oof-Wuuf");
        _levelOfHappiness++; // Increment happiness level after barking
    }

    public void TailWag()
    {
        Console.WriteLine("Dog Wags Tail");
    }
}