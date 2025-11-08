using models;

namespace models
{
    public class RecentlyInfected : Cordyceps
    {
        // Atributo privado
        private int hours;

        // Constructor
        public RecentlyInfected(string origin) : base(origin)
        {
            hours = 2;
        }

        // Método con retorno
        public override string Behavior()
        {
            return "En esta fase todavía es humano, esta es la primera etapa de la infeccion.";
        }

        // Método sin retorno
        public void ShowHours()
        {
            Console.WriteLine("Horas desde el contacto: " + hours + "horas. Esta fase puede durar de uno a dos dias, dependiendo del hospedero.");
        }

        // Función con retorno
        public int GetHours()
        {
            return hours;
        }

        // Función sin retorno
        public void ResetHours()
        {
            hours = 0;
        }
    }
}
