using System;
using System.Collections.Generic;

public class McDonalds
{
    public static void Main(string[] args)
    {
        double totalcost = 0;
        List<Item> itemList = new List<Item>();
        
        itemList.Add(new Item(1, "McFlurry", 9.99));
        itemList.Add(new Item(2, "Chicken Nuggets", 5.99));
        itemList.Add(new Item(3, "Fries", 3.99));
        
        Console.WriteLine("Please select an item from 1-3:");
        string input = Console.ReadLine();
        string [] arrayInput = input.Split(" ");
        
        for(int i=0; i<= arrayInput.Length-1; i++){
            foreach(var item in itemList){
                if(item.Id == Convert.ToInt32(arrayInput[i])){
                    Console.WriteLine("{0}, {1}, {2} ", item.Id, item.Name, item.Price);
                    totalcost += item.Price;
                }
            }
        }
        Console.WriteLine("Total: $" + totalcost);
    }
}

public class Item
{
    public int Id;
    public string Name;
    public double Price;
    
    public Item(int id, string name, double price)
    {
        this.Id = id;
        this.Name = name;
        this.Price = price;
    }
}