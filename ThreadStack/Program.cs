using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Stack<int> numbers = new Stack<int>();
        numbers.Push(5);
        numbers.Push(9);
        numbers.Push(86);


        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nTo poping'{0}'", numbers.Pop());
        Console.WriteLine("Peek at next item to destack: '{0}'", numbers.Peek());

        Stack<int> stack2 = new Stack<int>(numbers.ToArray());

        Console.WriteLine("\n Copy contents at first: ");

        int[] array2 = new int[numbers.Count*2];
        numbers.CopyTo(array2, numbers.Count);

        Stack<int> stack3 = new Stack<int>(array2);

        Console.WriteLine("\n Code after copy: ");
        foreach(int number in stack3)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nstack.Contains(86) = {0}", stack2.Contains(86));

        Console.WriteLine("\nstack2.Clear");
        stack2.Clear();
        Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
        
    }
}