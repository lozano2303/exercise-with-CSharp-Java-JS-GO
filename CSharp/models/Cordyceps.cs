namespace models
{
    public abstract class Cordyceps
    {
        // Atributo privado no nulo
        private string origin = "";

        // Propiedad pública con validación
        public string Origin
        {
            get { return origin; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    origin = value;
            }
        }

        // Constructor que asigna un valor válido
        public Cordyceps(string origin)
        {
            Origin = origin;
        }

        // Método sin retorno
        public void Spread()
        {
            Console.WriteLine("El hongo se propaga desde: " + Origin);
        }

        // Método abstracto con retorno
        public abstract string Behavior();
    }
}
