using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] words = new string[] {"the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"};

        foreach (string word in words)
        {
            int count = wordOccurrences(words, word);
            Console.WriteLine("{0}: {1}", word, count);
        }
    }

    public static int wordOccurrences(string[] words, string targetWord)
    {
        int count = 0;

        foreach (string word in words)
        {
            if (word.ToLower() == targetWord.ToLower())
            {
                count++;
            }
        }

        return count;
    }
}

