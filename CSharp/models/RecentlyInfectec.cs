using System;

namespace CSharp.models
{
    public class RecentlyInfected : Cordyceps
    {
        private string TimeInfected { set; get; }

        public RecentlyInfected(string origin, string timeInfected) : base(origin)
        {
            TimeInfected = timeInfected;
        }

        public string InfectedTime (string TimeInfected)
        {
            return "el tiempo de infeccion es de aproximadamente: " + TimeInfected;
        }

        public override string Behavior()
        {
            return "fase del cordyceps en la que aun hay conciencia";
        }

    }
}