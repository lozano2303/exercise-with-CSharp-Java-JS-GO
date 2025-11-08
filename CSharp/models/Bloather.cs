using models;

namespace models
{
    public class Bloater : Cordyceps
    {
        // Atributo privado
        private int resistance;

        // Constructor
        public Bloater(string origin) : base(origin)
        {
            resistance = 100;
        }

        // Método con retorno
        public override string Behavior()
        {
            return "ultima fase del cordyceps, en esta fase lanza esporas y es muy difícil de eliminar.\nConsejo: evita el enfrentamiento directo y usa un lanzallamas.";
        }

        // Método sin retorno
        public void ShowResistance()
        {
            Console.WriteLine("Resistencia: " + resistance);
        }

        // Función con retorno
        public int GetResistance()
        {
            return resistance;
        }

        // Función sin retorno
        public void ReduceResistance()
        {
            resistance -= 10;
        }
    }
}
