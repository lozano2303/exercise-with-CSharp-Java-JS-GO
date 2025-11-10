using System;
using models;


class Program
{
    static void Main(string[] args)
    {

        //instanciacion
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
        Console.WriteLine("\n Segunda fase del hongo Cordyceps completada. \n");

        
        Console.WriteLine("Fase 3: Stalker (acechador sigiloso) \n");
        Stalker phase3 = new Stalker("Seattle");
        phase3.Spread();
        Console.WriteLine(phase3.Behavior());
        phase3.ActivateStealth();
        Console.WriteLine(phase3.IsHidden());
        phase3.Reveal();
        Console.WriteLine("\n Tercera fase del hongo Cordyceps completada. \n");

        Console.WriteLine("Fase 4: Clicker (Chasqueador) \n");
        Clicker phase4 = new Clicker("Salt Lake City");
        phase4.Spread();
        Console.WriteLine(phase4.Behavior());
        phase4.EmitSound();
        Console.WriteLine(phase4.GetSound());
        phase4.ChangeSound("¡Chas!");
        Console.WriteLine("\n Cuarta fase del hongo Cordyceps completada. \n");

        Console.WriteLine("Fase 5: Bloather (gordinflon o hinchado) \n");
        Bloater phase5 = new Bloater("Jackson");
        phase5.Spread();
        Console.WriteLine(phase5.Behavior());
        phase5.ShowResistance();
        Console.WriteLine(phase5.GetResistance());
        phase5.ReduceResistance();
        Console.WriteLine("\n Quinta y última fase del hongo Cordyceps completada. \n");
    }
}
