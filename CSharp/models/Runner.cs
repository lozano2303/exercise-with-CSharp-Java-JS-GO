using models;

namespace models
{
    public class Runner : Cordyceps
    {
        // Atributo interno
        internal bool aggressive;

        // Constructor
        public Runner(string origin) : base(origin)
        {
            aggressive = true;
        }

        // Método con retorno
        public override string Behavior()
        {
            return "En esta etapa del Cordyceps el infectado corre rápido y ataca sin pensar a lo primero que ve.";
        }

        // Método sin retorno
        public void ShowAggression()
        {
            Console.WriteLine("Esta etapa es agresiva?: " + aggressive + ". Son faciles de abatir a mano limpia, pero peligrosos.");
        }

        // Función con retorno
        public bool IsAggressive()
        {
            return aggressive;
        }

        // Función sin retorno
        public void CalmDown()
        {
            aggressive = false;
        }
    }
}
