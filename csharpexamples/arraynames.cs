using System;
using System.Collections.Generic;

class HelloWorld {
    static void Main(string[] args) {
        string[] firstNames = { "Israa", "Kelsey", "Rakesh", "Rownie" };
        string[] lastNames = { "Rashid", "Kennedy", "Rakesh", "Matt" };

        for (int i = 0; i < firstNames.Length; i++) {
            Console.WriteLine(firstNames[i] + " " + lastNames[i]);
        }
    }
}