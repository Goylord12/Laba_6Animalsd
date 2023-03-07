﻿using System;

class Animal
{
    public string food;
    public string location;

    public Animal(string food, string location)
    {
        this.food = food;
        this.location = location;
    }
    public virtual void makeNoise()
    {
        Console.WriteLine("Животное спит.");
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
    public Dog(string food, string location) : base(food, location)
    {
        this.food = food;
        this.location = location;
    }

    public override void makeNoise()
    {
        Console.WriteLine("Собака лает.");
    }

    public override void eat()
    {
        Console.WriteLine("Собака кушает кость.");

    }

    public override void sleep()
    {
        Console.WriteLine("Собака спит.\n");
    }
}

class Cat : Animal
{

    public Cat(string food, string location) : base(food, location)
    {
        this.food = food;
        this.location = location;
    }

    public override void makeNoise()
    {
        Console.WriteLine("Кошка мяукает.");
    }

    public override void eat()
    {
        Console.WriteLine("Кошка ест рыбу.");
    }

    public override void sleep()
    {
        Console.WriteLine("Кошка откисает.\n");
    }
}

class Horse : Animal
{
    public Horse(string food, string location) : base(food, location)
    {
        this.food = food;
        this.location = location;
    }

    public override void makeNoise()
    {
        Console.WriteLine("Лошадь ржет.");
    }

    public override void eat()
    {
        Console.WriteLine("Лошадь ест сено.");
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
        Console.WriteLine("Еда: " + animal.food);
        Console.WriteLine("Местоположение: " + animal.location + "\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Мясо", "Вольер");
        dog.makeNoise();
        dog.eat();
        dog.sleep();

        Cat cat = new Cat("Корм", "Дом");
        cat.makeNoise();
        cat.eat();
        cat.sleep();

        Horse horse = new Horse("Овес", "Стойло");
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
