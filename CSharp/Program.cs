using System;
using models;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simulación de Cordyceps \n \nFase 1: Recently Infected (infectado reciente) \n");
        RecentlyInfected phase1 = new RecentlyInfected("Boston");
        phase1.Spread();
        Console.WriteLine(phase1.Behavior());
        phase1.ShowHours();
        Console.WriteLine(phase1.GetHours());
        phase1.ResetHours();
        Console.WriteLine("\n Primera fase del hongo Cordyceps completada. \n");

        Console.WriteLine("Fase 2: Runner (corredor agresivo) \n");
        Runner phase2 = new Runner("Pittsburgh");
        phase2.Spread();
        Console.WriteLine(phase2.Behavior());
        phase2.ShowAggression();
        Console.WriteLine(phase2.IsAggressive());
        phase2.CalmDown();
    }
}
