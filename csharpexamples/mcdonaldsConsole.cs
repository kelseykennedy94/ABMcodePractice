using System;
using System.Collections.Generic;


public class Mcdonalds
{
    static void Main(string[] args)
    {
        string province = provinceSelection();
        string orderType = orderTypeSelection();
        string menuItem = menuItemSelection();
        orderSomethingElse();
    }

    public static string provinceSelection()
    {
        Console.WriteLine("----------Welcome to McDonalds!----------");
        Console.WriteLine("\n");
        Console.WriteLine("Please select the province you are in:");
        Console.WriteLine("1. Alberta 2. Quebec 3. Ontario");
        string provinceSelected = Console.ReadLine();
        Console.WriteLine("Province selected: " + provinceSelected);

        if (provinceSelected == "1")
        {
            Console.WriteLine("Alberta is selected");
        }
        else if (provinceSelected == "2")
        {
            Console.WriteLine("Quebec is selected");
        }
        else if (provinceSelected == "3")
        {
            Console.WriteLine("Ontario is selected");
        }

        return provinceSelected;
    }

    public static string orderTypeSelection()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Please select your order type:");
        Console.WriteLine("1. Delivery 2. Eat-in");
        string orderTypeSelected = Console.ReadLine();
        Console.WriteLine("Order type selected: " + orderTypeSelected);

        if (orderTypeSelected == "1")
        {
            Console.WriteLine("Delivery is selected");
        }
        else if (orderTypeSelected == "2")
        {
            Console.WriteLine("Eat-in is selected");
        }

        return orderTypeSelected;
    }

    public static string menuItemSelection()
{
    List<(int, string, double)> menuItems = new List<(int, string, double)>
    {
        (1, "Big Mac", 5.99),
        (2, "Quarter Pounder", 6.99),
        (3, "Chicken McNuggets", 7.99),
        (4, "Filet-O-Fish", 5.49),
        (5, "McChicken", 4.49),
        (6, "Double Cheeseburger", 3.99),
        (7, "Fries", 2.49),
        (8, "Soft Drink", 1.99),
        (9, "McFlurry", 3.49),
        (10, "Apple Pie", 1.49)
    };

    Console.WriteLine("\n");
    Console.WriteLine("Please select your menu item:");
    foreach ((int id, string name, double price) in menuItems)
    {
        Console.WriteLine($"{id}. {name} - ${price:F2}");
    }

    string menuItemSelected = Console.ReadLine();
    int index = int.Parse(menuItemSelected) - 1;
    Console.WriteLine($"Menu item selected: {menuItems[index].Item2} - ${menuItems[index].Item3:F2}");

    return menuItemSelected;
}

    public static void orderSomethingElse()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Would you like to order something else? (Y/N)");
        string answer = Console.ReadLine();

        if (answer == "Y")
        {
            Console.WriteLine("\n");
            string menuItem = menuItemSelection();
            orderSomethingElse();
        }
    }
}