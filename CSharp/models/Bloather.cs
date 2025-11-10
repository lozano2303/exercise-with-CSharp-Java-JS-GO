using models;

namespace models
{
    public class Bloater : Cordyceps
    {
        //atributo privado
        private int resistance;

        // constructor
        public Bloater(string origin) : base(origin)
        {
            resistance = 100;
        }

        //metodo con retorno
        public override string Behavior()
        {
            return "ultima fase del cordyceps, en esta fase lanza esporas y es muy difícil de eliminar.\nConsejo: evita el enfrentamiento directo y usa un lanzallamas.";
        }

        // metodo sin retorno
        public void ShowResistance()
        {
            Console.WriteLine("Resistencia: " + resistance);
        }

        // funcion con retorno
        public int GetResistance()
        {
            return resistance;
        }

        // funcion sin retorno
        public void ReduceResistance()
        {
            resistance -= 10;
        }
    }
}
