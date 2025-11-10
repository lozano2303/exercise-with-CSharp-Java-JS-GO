using models;

namespace models
{
    public class RecentlyInfected : Cordyceps
    {
        // atributo privado
        private int hours;

        //constructor
        public RecentlyInfected(string origin) : base(origin)
        {
            hours = 2;
        }

        // metodo con retorno
        public override string Behavior()
        {
            return "En esta fase todavía es humano, esta es la primera etapa de la infeccion.";
        }

        //metodo sin retorno
        public void ShowHours()
        {
            Console.WriteLine("Horas desde el contacto: " + hours + "horas. Esta fase puede durar de uno a dos dias, dependiendo de la persona infectada.");
        }

        // funcion con retorno
        public int GetHours()
        {
            return hours;
        }

        // funcion sin retorno
        public void ResetHours()
        {
            hours = 0;
        }
    }
}
