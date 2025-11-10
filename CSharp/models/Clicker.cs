using models;

namespace models
{
    public class Clicker : Cordyceps
    {
        // atributo privado
        private string sound;

        //constructor
        public Clicker(string origin) : base(origin)
        {
            sound = "¡Click!";
        }

        // metodo con retorno
        public override string Behavior()
        {
            return "En esta fase el hongo ha dejado ciego al infectado, usa ecolocalización para cazar.\nConsejo: no lo enfrentes a mano limpia, evita el enfrentamiento.";
        }

        //metodo sin retorno
        public void EmitSound()
        {
            Console.WriteLine("Sonido emitido: " + sound);
        }

        //funcion con retorno
        public string GetSound()
        {
            return sound;
        }

        // funcion sin retorno
        public void ChangeSound(string newSound)
        {
            sound = newSound;
            Console.WriteLine("El chasqueador ha hecho un sonido distinto: " + sound);
        }
    }
}
