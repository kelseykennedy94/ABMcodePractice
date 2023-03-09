using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
{
    List<bDays> list = new List<bDays>();
    bDays kelsey = new bDays("Kelsey Kennedy", new DateTime(1994, 03, 09));
    bDays israa = new bDays("Israa Rashid", new DateTime(2000, 05, 23));
    bDays basant = new bDays("Basant Gera", new DateTime(1993, 06, 15));
    bDays john = new bDays("John Mata", new DateTime(2002, 09, 12));
    bDays mj = new bDays("MJ Pineda", new DateTime(2005, 11, 01));
    
    list.Add(kelsey);
    list.Add(israa);
    list.Add(basant);
    list.Add(john);
    list.Add(mj);
    
    List<bDays> filteredList = new List<bDays>();  // Declare the filtered list

    foreach(var a in list){
        if (a.Dob >= new DateTime(2000, 01, 01)) {
            filteredList.Add(a);
            Console.WriteLine(a.Name + " : " + a.Dob.ToString("dd MMMM yyyy"));
        }
    }
}

public class bDays{
    public string name;
    public DateTime dob;
    
    public bDays(string name, DateTime dob){
        this.name = name;
        this.dob = dob;
    }

    public string Name{
        get { return name; }
        set { name = value; }
    }

    public DateTime Dob{
        get { return dob; }
        set { dob = value; }
        }
    }
}