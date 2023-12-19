using System;

class Program
{
    static void Main(string[] args)
    {
        //O(n^2) -> dois loops aninhados, a complexidade é n * n
        string[] boxes = new string[] { "A", "B", "C", "D", "E" };
        LogAllPairsOfArray(boxes);
    }

    static void LogAllPairsOfArray(string[] boxes)
    {
        for (int i = 0; i < boxes.Length; i++)
        {
            for (int j = 0; j < boxes.Length; j++)
            {
                Console.WriteLine(boxes[i] + ", " + boxes[j]);
            }
        }
    }
}
