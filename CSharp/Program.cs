using System;
using CSharp.models;


class Program
{
    static void Main(string[] args)
    {
        List<Cordyceps> stages = new List<Cordyceps>
        {
            new RecentlyInfected("Boston", "5 horas"),
        };

        foreach (var stage in stages)
        {
            stage.Propagar(); // Método común
            Console.WriteLine(stage.Behavior()); // Polimorfismo
            Console.WriteLine("-----");
        }
    }
}
