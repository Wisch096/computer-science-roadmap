using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Nao importa se a palavra "nemo" está no inicio do array, e adicionamos um break no loop, o bigO sempre irá considerar o pior caso, ou seja, o "nemo" no final do array.
        string[] nemo = { "nemo", "jack", "hill", "romeo", "casta", "nemo" };
        string[] large = new string[1000];
        Array.Fill(large, "nemo");

        void findNemo(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "nemo")
                {
                    Console.WriteLine("Found Nemo!!");
                    break; 
                }
            }
        }
        findNemo(large);
    }
}
