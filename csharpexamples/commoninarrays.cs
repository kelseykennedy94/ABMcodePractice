using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
//declare arrays
        int[] array1 = new int[] {4, 7, 3};
        int[] array2 = new int[] {3, 9, 2};
        int[] array3 = new int[] {3, 5, 10};

//use for loops for possible combinations
        for(int a = 0; a < array1.Length; a++) {
            for(int b = 0; b < array2.Length; b++) {
                for(int c = 0; c < array3.Length; c++) {
//if there is a common number, print it
                    if(array1[a] == array2[b] && array1[a] == array3[c]) {
                        Console.WriteLine(array1[a]);
                    }
                }
            }
        }
    }
}