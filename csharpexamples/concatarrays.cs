using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int[] array1 = {1, 2, 6, 5, 3, 2, 9, 3, 3};
       int[] array2 = {3, 6, 3, 1, 2, 5, 7, 3, 1, 1, 6};
       
       int[] join = array1.Concat(array2).ToArray();
       
       Array.Sort(join);
       
       foreach (int i in join){
           Console.Write(i + " ");
       }
    }
}