using System;

class Animal
{
    public string food;
    public string location;
    public string voice;

    public Animal(string food, string location, string voice)
    {
        this.food = food;
        this.location = location;
        this.voice = voice;
    }
    public virtual void makeNoise()
    {
        Console.WriteLine("Животное шумит.");
    }

    public virtual void eat()
    {
        Console.WriteLine("Животное ест.");
    }

    public virtual void sleep()
    {
        Console.WriteLine("Животное спит.");
    }
}

class Dog : Animal
{
    public Dog(string food, string location, string voice) : base(food, location, voice)
    {
    
    }

    public override void makeNoise()
    {
        Console.WriteLine($"Собака {voice}.");
    }

    public override void eat()
    {
        Console.WriteLine($"Собака кушает {food}.");

    }

    public override void sleep()
    {
        Console.WriteLine("Собака спит.\n");
    }
}

class Cat : Animal
{

    public Cat(string food, string location, string voice) : base(food, location, voice)
    {

    }

    public override void makeNoise()
    {
        Console.WriteLine($"Кошка {voice}.");
    }

    public override void eat()
    {
        Console.WriteLine($"Кошка ест  {food}.");
    }

    public override void sleep()
    {
        Console.WriteLine("Кошка откисает.\n");
    }
}

class Horse : Animal
{
    public Horse(string food, string location, string voice) : base(food, location, voice)
    {
   
    }

    public override void makeNoise()
    {
        Console.WriteLine($"Лошадь {voice}.");
    }

    public override void eat()
    {
        Console.WriteLine($"Лошадь ест {food}.");
    }
    public override void sleep()
    {
        Console.WriteLine("Лошадь овец считает.\n");
    }
}

class Veterinarian
{
    public void treatAnimal(Animal animal)
    {
        Console.WriteLine("Животное: " + animal);
        Console.WriteLine("Звук: " + animal.voice);
        Console.WriteLine("Еда: " + animal.food);
        Console.WriteLine("Местоположение: " + animal.location + "\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("мясо", "вольер", "лает");
        dog.makeNoise();
        dog.eat();
        dog.sleep();

        Cat cat = new Cat("корм", "дом", "мяукает");
        cat.makeNoise();
        cat.eat();
        cat.sleep();

        Horse horse = new Horse("овес", "стойло", "ржет");
        horse.makeNoise();
        horse.eat();
        horse.sleep();

        Veterinarian veterinarian = new Veterinarian();
        veterinarian.treatAnimal(dog);
        veterinarian.treatAnimal(cat);
        veterinarian.treatAnimal(horse);

        Console.ReadKey();
    }
}
