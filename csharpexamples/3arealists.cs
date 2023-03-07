using System;
using System.Collections.Generic;

class HelloWorld {
    static List<string> areas;
    static List<string> subareas;
    static List<string> cities;

    static void LoadAreas() {
        areas = new List<string>();
        areas.Add("AB");
        areas.Add("BC");
        areas.Add("SK");
    }

    static void LoadSubareas() {
        subareas = new List<string>();
        subareas.Add("AB South");
        subareas.Add("BC West");
        subareas.Add("SK Central");
    }

    static void LoadCities() {
        cities = new List<string>();
        cities.Add("AB Calgary");
        cities.Add("BC Vancouver");
        cities.Add("SK Saskatoon");
    }

    static void Main(string[] args)
{
    LoadAreas();
    LoadSubareas();
    LoadCities();

    Console.Write("Enter an area: ");
    string input = Console.ReadLine();

    Console.WriteLine("Subareas:");
    for (int i = 0; i < areas.Count; i++)
    {
        if (areas[i] == input)
        {
            Console.WriteLine(subareas[i]);
        }
    }

    Console.WriteLine("Cities:");
    for (int i = 0; i < areas.Count; i++)
    {
        if (areas[i] == input)
        {
            Console.WriteLine(cities[i]);
            }
        }
    }
}