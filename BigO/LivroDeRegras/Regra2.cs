using System;

class Program
{
    static void PrintFirstItemThenFirstHalfThenSayHi100Times(string[] items)
    {
        //Todas constantes devem ser desconsideradas, resultado -> O(n)
        Console.WriteLine(items[0]);

        int middleIndex = items.Length / 2;
        int index = 0;

        while (index < middleIndex)
        {
            Console.WriteLine(items[index]);
            index++;
        }

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("hi");
        }
    }
}