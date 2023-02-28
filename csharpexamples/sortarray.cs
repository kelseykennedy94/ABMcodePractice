using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
//declare array
    int[] array = new int[]{-50, -10, -6, -5, 30, 90, -52, -62, -90, 60, 10, -6};
    
//sort array
    Array.Sort(array);
    
//use for loop for going through each number
    for(int a=0; a < array.Length; a++){
        
//print
        Console.WriteLine(array[a]);
        }
    }
}
