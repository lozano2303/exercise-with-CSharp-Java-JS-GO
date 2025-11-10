namespace models
{
    public abstract class Cordyceps
    {
        // atributo privado (no nulo)
        private string origin = "";

        // propiedad publica 
        public string Origin
        {
            get { return origin; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    origin = value;
            }
        }

        // constructor
        public Cordyceps(string origin)
        {
            Origin = origin;
        }

        // metodo sin retorno
        public void Spread()
        {
            Console.WriteLine("El hongo se propaga desde: " + Origin);
        }

        //metodo polimorfico
        public abstract string Behavior();
    }
}
