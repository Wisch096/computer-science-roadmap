using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
        //O(n) --> Tempo Linear

        string[] nemo = new string[] { "nemo" };
        string[] everyone = {"dory", "bruce", "marlin", "nemo", "gill", "bloat", "nigel", "squirt", "darla", "hank"};
        string[] nemos = Enumerable.Repeat("nemo", 10000).ToArray();

        for (var i = 0; i < nemos.Length; i++) { 
            if (nemos[i] == "nemo") {
                Console.WriteLine("achou o NEMO!");
            }
        }
    }
  
}