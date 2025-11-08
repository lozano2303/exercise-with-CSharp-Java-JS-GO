using models;

namespace models
{
    public class Clicker : Cordyceps
    {
        // Atributo privado
        private string sound;

        // Constructor
        public Clicker(string origin) : base(origin)
        {
            sound = "¡Click!";
        }

        // Método con retorno
        public override string Behavior()
        {
            return "En esta fase el hongo ha dejado ciego al infectado, usa ecolocalización para cazar.\nConsejo: no lo enfrentes a mano limpia, evita el enfrentamiento.";
        }

        // Método sin retorno
        public void EmitSound()
        {
            Console.WriteLine("Sonido emitido: " + sound);
        }

        // Función con retorno
        public string GetSound()
        {
            return sound;
        }

        // Función sin retorno
        public void ChangeSound(string newSound)
        {
            sound = newSound;
            Console.WriteLine("El chasqueador ha hecho un sonido distinto: " + sound);
        }
    }
}
