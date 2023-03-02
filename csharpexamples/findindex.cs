using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] array1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int[] array2 = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        int answer1 = findIndex(array1);
        int answer2 = findIndex(array2);
        
        Console.WriteLine(answer1);
        Console.WriteLine(answer2);
    }
       
    public static int findIndex(int[] array)
    {
        int length = array.Length;
        int index = length / 2;
        
        if (length % 2 == 0)
        {
            return array[index];
        }
        else
        {
            return array[index];
        }
    }
}