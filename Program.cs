using System;
using acfour_library_sergi_albalat;
public class Program
{
    public static void Main()
    {
        const string Msg1 = "Write how many numbers do you want to store";
        const string Msg2 = "Write a number";
        const string Msg3 = "Your numbers:";
        int capacity;
        Console.WriteLine(Msg1);
        capacity = int.Parse(Console.ReadLine());
        int[] numbers = new int[capacity];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(Msg2);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(Msg3);
        MyMethods.WriteResult(numbers);
    }
}