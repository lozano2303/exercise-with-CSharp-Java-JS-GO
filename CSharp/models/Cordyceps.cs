using System;

namespace CSharp.models
{
    public abstract class Cordyceps
    {
        private string origin { get; set; }
        public string Origin
        {
            get { return origin; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    origin = value;
            }
        }

        public Cordyceps(string origin)
        {
            this.origin = origin;
        }

        // Método común sin retorno
        public void Propagar()
        {
            Console.WriteLine($"El hongo se propaga desde: {Origin}");
        }

        // metodo abstracto
        public abstract string Behavior();
    }
}