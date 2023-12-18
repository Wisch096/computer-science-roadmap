using System;
using System.Diagnostics;
using System.Linq;

class MainClass {
    //Como calcular a complexidade e escalabilidade do algoritmo?
    static void Main() {
        string[] nemo = new string[] { "nemo" };
        string[] everyone = {"dory", "bruce", "marlin", "nemo", "gill", "bloat", "nigel", "squirt", "darla", "hank"};
        string[] nemos = Enumerable.Repeat("nemo", 10000).ToArray();

        Stopwatch stopwatch = new Stopwatch();
        for (var i = 0; i < nemos.Length; i++) {
            stopwatch.Start();
            if (nemos[i] == "nemo") {
                Console.WriteLine("Found NEMO!");
            }
        stopwatch.Stop();
        }
    Console.WriteLine($"Levou {stopwatch.ElapsedMilliseconds} milisegundos");
    }
}
    
   
       
       
