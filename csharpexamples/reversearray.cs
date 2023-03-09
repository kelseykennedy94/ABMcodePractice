using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string originalName = "kelsey kennedy";
        string reversedName = ReverseName(originalName);
        Console.WriteLine(reversedName);
    }

    static string ReverseName(string name)
    {
        string[] parts = name.Split(' ');
        string reversedFirstName = new string(parts[0].Reverse().ToArray());
        string reversedLastName = new string(parts[1].Reverse().ToArray());
        return reversedFirstName + " " + reversedLastName;
    }
}