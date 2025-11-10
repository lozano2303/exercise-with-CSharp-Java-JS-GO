using models;

namespace models
{
    public class Stalker : Cordyceps
    {
        // atributo protegido
        protected bool hidden;

        //constructor
        public Stalker(string origin) : base(origin)
        {
            hidden = true;
        }

        // metodo con retorno
        public override string Behavior()
        {
            return "En esta fase del cordyceps sigue siendo muy parecida a la anterior, pero en esta se oculta y ataca por sorpresa.";
        }

        //metodo sin retorno protegido
        protected void Hide()
        {
            Console.WriteLine("El acechador se ha escondido. Cuidado al acercarse.");
        }

        // metodo sin retorno que accede al protegido
        public void ActivateStealth()
        {
            Hide();
        }

        //funcion con retorno
        public bool IsHidden()
        {
            return hidden;
        }

        // funcion sin retorno
        public void Reveal()
        {
            hidden = false;
        }
    }
}
