using System;
//Salama
class Program
{
    static void Main(string[] args)
    {
        // Testing Exercise 4
        Console.WriteLine("--- Exercise 4 ---");
        // array
        string[] words = { "Apple", "Banana", "Watermelon", "Kiwi" };
        Console.WriteLine("Longest word length: " + GetLongestStringLength(words));

        // Testing Exercise 5
        Console.WriteLine("\n--- Exercise 5 ---");
        Console.WriteLine("Is 5+10 > 12? : " + IsSumBiggerThanThird(5, 10, 12));
        Console.WriteLine("Is 2+3 > 10? : " + IsSumBiggerThanThird(2, 3, 10));
    }

    // Exercise 4: Returns the length of the longest string in the array
    public static int GetLongestStringLength(string[] texts)
    {
        if (texts == null || texts.Length == 0) return 0;
        
        int maxLength = 0;
        foreach (string text in texts)
        {
            if (text != null && text.Length > maxLength)
            {
                maxLength = text.Length;
            }
        }
        return maxLength;
    }

    // Exercise 5: Adds the first two numbers and checks if the sum is bigger than the third
    public static bool IsSumBiggerThanThird(int num1, int num2, int num3)
    {
        int sum = num1 + num2;
        return sum > num3;
    }
}