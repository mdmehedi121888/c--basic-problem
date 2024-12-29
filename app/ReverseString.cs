using System;

public class ReverseString
{
    public void Reverse()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter a string to reverse: ");
                string str = Console.ReadLine();
                string str1 = "";
                for (int i = str.Length - 1; i >= 0; --i)
                {
                    str1 += str[i];
                }
                Console.WriteLine($"Reverse String: {str1}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a valid input.");
            }
        }
    }
}