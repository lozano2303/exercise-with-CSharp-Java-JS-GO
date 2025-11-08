using models;

namespace models
{
    public class Stalker : Cordyceps
    {
        // Atributo protegido
        protected bool hidden;

        // Constructor
        public Stalker(string origin) : base(origin)
        {
            hidden = true;
        }

        // Método con retorno
        public override string Behavior()
        {
            return "En esta fase del cordyceps sigue siendo muy parecida a la anterior, pero en esta se oculta y ataca por sorpresa.";
        }

        // Método sin retorno protegido
        protected void Hide()
        {
            Console.WriteLine("El acechador se ha escondido. Cuidado al acercarse.");
        }

        // Método sin retorno público que accede al protegido
        public void ActivateStealth()
        {
            Hide();
        }

        // Función con retorno
        public bool IsHidden()
        {
            return hidden;
        }

        // Función sin retorno
        public void Reveal()
        {
            hidden = false;
        }
    }
}
