using System;

class HelloWorld
{
    static void Main(string[] args)
    {
        bool isAdult = IsAdult(25);
        string name = "kelsey";
        double weight = 65.5;
        int age = 28;
        char firstNameInitial = 'k';

        Console.WriteLine("bool: " + isAdult);
        Console.WriteLine("string: " + myName(name));
        Console.WriteLine("double: " + myWeight(weight));
        Console.WriteLine("int: " + myAge(age));
        Console.WriteLine("char: " + myInitial(firstNameInitial));
    }

    static bool IsAdult(int age)
    {
        return age >= 18;
    }

    static string myName(string name)
    {
        return name;
    }

    static double myWeight(double weight)
    {
        return weight;
    }

    static int myAge(int age)
    {
        return age;
    }

    static char myInitial(char initial)
    {
        return initial;
    }
}