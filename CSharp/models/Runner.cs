using models;

namespace models
{
    public class Runner : Cordyceps
    {
        //atributo interno
        internal bool aggressive;

        // constructor
        public Runner(string origin) : base(origin)
        {
            aggressive = true;
        }

        //metodo con retorno
        public override string Behavior()
        {
            return "En esta etapa del Cordyceps el infectado corre rápido y ataca sin pensar a lo primero que ve.";
        }

        // metodo sin retorno
        public void ShowAggression()
        {
            Console.WriteLine("Esta etapa es agresiva?: " + aggressive + ". Son faciles de abatir a mano limpia, pero peligrosos.");
        }

        // funcion con retorno
        public bool IsAggressive()
        {
            return aggressive;
        }

        //funcion sin retorno
        public void CalmDown()
        {
            aggressive = false;
        }
    }
}
